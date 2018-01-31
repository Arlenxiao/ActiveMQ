using Apache.NMS;
using Apache.NMS.ActiveMQ;
using Apache.NMS.Util;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace AMQ
{
    public class ActiveMQHelper
    {
        #region 变量&属性
        /// <summary>
        /// 连接工厂
        /// </summary>
        private IConnectionFactory factory;

        /// <summary>
        /// 连接对象
        /// </summary>
        private IConnection connection;

        /// <summary>
        /// 会话对象
        /// </summary>
        private ISession session;

        /// <summary>
        /// 目标对象
        /// </summary>
        private IDestination destination;

        /// <summary>
        /// 消息生产者
        /// </summary>
        private IMessageProducer producer;

        /// <summary>
        /// 消息消费者
        /// </summary>
        private IMessageConsumer consumer;

        /// <summary>
        /// 地址
        /// </summary>
        public String URI { get; set; }
        /// <summary>
        /// 是否是主题模式
        /// </summary>
        public Boolean IsTopic { get; set; }

        /// <summary>
        /// 主题名称
        /// </summary>
        public String TopicName { get; set; }

        /// <summary>
        /// 发送消息
        /// </summary>
        public String Message { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        public String UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public String Password { get; set; }

        /// <summary>
        /// 过滤信息
        /// </summary>
        public String Selector { get; set; }

        /// <summary>
        /// 消息属性
        /// </summary>
        public Dictionary<String, String> MessageProperties = new Dictionary<string, string>();

        /// <summary>
        /// 客户端ID
        /// </summary>
        public String ClientID { get; set; }

        #endregion

        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public ActiveMQHelper()
        {
            factory = null;
            connection = null;
            session = null;
            producer = null;
            consumer = null;
        }

        /// <summary>
        /// 析构函数
        /// </summary>
        ~ActiveMQHelper()
        {
            if (producer != null) { producer.Dispose(); }

            if (consumer != null) { consumer.Dispose(); }
        }

        #endregion

        #region 打开&关闭MQ
        /// <summary>
        /// 启动MQ
        /// </summary>
        public void Start()
        {
            try
            {
                factory = new ConnectionFactory(URI);
                connection = factory.CreateConnection(UserName, Password);
                connection.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// 关闭MQ
        /// </summary>
        public void Close()
        {
            try
            {
                if (session != null) { session.Close(); }

                if (connection != null)
                {
                    connection.Stop();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion

        #region 生产者

        /// <summary>
        /// 创建生产者
        /// </summary>
        public void CreateProduce()
        {
            if (connection == null) { Start(); return; }

            session = connection.CreateSession();
            if (IsTopic)
            {
                //IDestination destination = SessionUtil.GetDestination(session, "topic://TaskIssue_VoiceSM");
                ////新建生产者对象  
                //producer = session.CreateProducer(destination);
                //producer.DeliveryMode= MsgDeliveryMode.NonPersistent;//ActiveMQ服务器停止工作后，消息不再保留   

                producer = session.CreateProducer(new Apache.NMS.ActiveMQ.Commands.ActiveMQTopic(TopicName));
                //connection.Start();
            }
            else
            {
                //IDestination destination = SessionUtil.GetDestination(session, "queue://TaskIssue_VoiceSM");
                ////新建生产者对象  
                //producer = session.CreateProducer(destination);
                //producer.DeliveryMode= MsgDeliveryMode.NonPersistent;//ActiveMQ服务器停止工作后，消息不再保留   

                producer = session.CreateProducer(new Apache.NMS.ActiveMQ.Commands.ActiveMQQueue(TopicName));
                //connection.Start();
            }
        }

        /// <summary>
        /// 发送数据
        /// </summary>
        public void Send()
        {
            if (producer == null) return;

            ITextMessage msg = producer.CreateTextMessage();
            msg.Text = Message;

            foreach (var item in MessageProperties)
            {
                msg.Properties.SetString(item.Key, item.Value);
            }

            producer.Send(msg, MsgDeliveryMode.NonPersistent, Apache.NMS.MsgPriority.Normal, TimeSpan.MinValue);
        }
        #endregion

        #region 消费者
        /// <summary>
        /// 创建消费者
        /// </summary>
        /// <returns></returns>
        public IMessageConsumer CreateConsumer()
        {
            if (connection == null) { Start(); return consumer; }

            if (!string.IsNullOrEmpty(ClientID))
            {
                try
                {
                    connection.ClientId = ClientID;
                }
                catch { return consumer; }

            }
            session = connection.CreateSession();
            //connection.Start();
            if (IsTopic)
            {
                //consumer = session.CreateConsumer(new Apache.NMS.ActiveMQ.Commands.ActiveMQTopic(TopicName), null, false);
                consumer = session.CreateDurableConsumer(new Apache.NMS.ActiveMQ.Commands.ActiveMQTopic(TopicName), Selector, null, true);
            }
            else
            {
                consumer = session.CreateConsumer(new Apache.NMS.ActiveMQ.Commands.ActiveMQQueue(TopicName), null, false);
            }

            consumer.Listener += Consumer_Listener;

            return consumer;
        }

        public delegate void SendMessageDelegate(IMessage msg);
        public event SendMessageDelegate SendMessageEvent;

        private void Consumer_Listener(IMessage message)
        {
            try
            {
                if (SendMessageEvent != null)
                {
                    SendMessageEvent(message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion
    }

    /// <summary>
    /// Active MQ 基类
    /// </summary>
    public class ActiveMQBase
    {
        #region 变量&属性
        /// <summary>
        /// 连接工厂
        /// </summary>
        protected IConnectionFactory factory;

        /// <summary>
        /// 连接对象
        /// </summary>
        protected IConnection connection;

        /// <summary>
        /// 会话对象
        /// </summary>
        protected ISession session;

        /// <summary>
        /// 目标对象
        /// </summary>
        protected IDestination destination;

        /// <summary>
        /// 消息生产者
        /// </summary>
        protected IMessageProducer producer;

        /// <summary>
        /// 消息消费者
        /// </summary>
        protected IMessageConsumer consumer;

        /// <summary>
        /// 地址
        /// </summary>
        public String URI { get; set; }
        /// <summary>
        /// 是否是主题模式
        /// </summary>
        public Boolean IsTopic { get; set; }

        /// <summary>
        /// 主题名称
        /// </summary>
        public String TopicName { get; set; }

        /// <summary>
        /// 发送消息
        /// </summary>
        public String Message { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        public String UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public String Password { get; set; }

        /// <summary>
        /// 过滤信息
        /// </summary>
        public String Selector { get; set; }

        /// <summary>
        /// 消息属性
        /// </summary>
        public ConcurrentDictionary<String, String> MessageProperties = new ConcurrentDictionary<string, string>();

        /// <summary>
        /// 客户端ID
        /// </summary>
        public String ClientID { get; set; }

        #endregion

        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public ActiveMQBase()
        {
            factory = null;
            connection = null;
            session = null;
            producer = null;
            consumer = null;
        }

        /// <summary>
        /// 析构函数
        /// </summary>
        ~ActiveMQBase()
        {
            if (producer != null) { producer.Dispose(); }

            if (consumer != null) { consumer.Dispose(); }
        }

        #endregion
    }
    /// <summary>
    /// Active MQ 生产者
    /// </summary>
    public class ActiveMQProduce : ActiveMQBase
    {
        #region 打开&关闭MQ
        /// <summary>
        /// 启动MQ
        /// </summary>
        public void Start()
        {
            try
            {
                factory = new ConnectionFactory(URI);
                connection = factory.CreateConnection(UserName, Password);
                connection.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// 关闭MQ
        /// </summary>
        public void Close()
        {
            try
            {
                if (session != null) { session.Close(); }

                if (connection != null)
                {
                    connection.Stop();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion

        #region 生产者

        /// <summary>
        /// 创建生产者
        /// </summary>
        public void CreateProduce()
        {
            if (connection == null) { Start(); return; }

            session = connection.CreateSession();
            if (IsTopic)
            {
                //IDestination destination = SessionUtil.GetDestination(session, "topic://TaskIssue_VoiceSM");
                ////新建生产者对象  
                //producer = session.CreateProducer(destination);
                //producer.DeliveryMode= MsgDeliveryMode.NonPersistent;//ActiveMQ服务器停止工作后，消息不再保留   

                producer = session.CreateProducer(new Apache.NMS.ActiveMQ.Commands.ActiveMQTopic(TopicName));
                //connection.Start();
            }
            else
            {
                //IDestination destination = SessionUtil.GetDestination(session, "queue://TaskIssue_VoiceSM");
                ////新建生产者对象  
                //producer = session.CreateProducer(destination);
                //producer.DeliveryMode= MsgDeliveryMode.NonPersistent;//ActiveMQ服务器停止工作后，消息不再保留   

                producer = session.CreateProducer(new Apache.NMS.ActiveMQ.Commands.ActiveMQQueue(TopicName));
                //connection.Start();
            }
        }

        /// <summary>
        /// 发送数据
        /// </summary>
        public void Send()
        {
            if (producer == null) return;

            ITextMessage msg = producer.CreateTextMessage();
            msg.Text = Message;

            foreach (var item in MessageProperties)
            {
                msg.Properties.SetString(item.Key, item.Value);
            }

            producer.Send(msg, MsgDeliveryMode.NonPersistent, MsgPriority.Normal, TimeSpan.MinValue);
        }
        #endregion
    }

    /// <summary>
    /// Active MQ 消费者
    /// </summary>
    public class ActiveMQConsumer : ActiveMQBase
    {
        /// <summary>
        /// 消费者接收推送消息委托
        /// </summary>
        /// <param name="msg"></param>
        public delegate void SendMessageDelegate(IMessage msg);
        /// <summary>
        /// 监听接收推送消息事件
        /// </summary>
        public event SendMessageDelegate SendMessageEvent;

        #region 打开&关闭MQ

        /// <summary>
        /// 关闭MQ
        /// </summary>
        public void Close()
        {
            try
            {
                if (consumer != null)
                {
                    consumer.Listener -= Consumer_Listener;
                }

                if (session != null) { session.Close(); }

                if (connection != null)
                {
                    connection.Stop();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion

        #region 消费者
        /// <summary>
        /// 创建消费者
        /// </summary>
        /// <returns></returns>
        public void CreateConsumer()
        {
            try
            {
                factory = new ConnectionFactory(URI);
                connection = factory.CreateConnection(UserName, Password);

                if (connection == null) {return; }

                if (!string.IsNullOrEmpty(ClientID))
                {
                    try
                    {
                        connection.ClientId = ClientID;
                    }
                    catch { return; }

                }
                session = connection.CreateSession();

                if (IsTopic)
                {
                    //consumer = session.CreateConsumer(new Apache.NMS.ActiveMQ.Commands.ActiveMQTopic(TopicName), null, false);
                    consumer = session.CreateDurableConsumer(new Apache.NMS.ActiveMQ.Commands.ActiveMQTopic(TopicName), Selector, null, true);
                }
                else
                {
                    consumer = session.CreateConsumer(new Apache.NMS.ActiveMQ.Commands.ActiveMQQueue(TopicName), null, false);
                }

                consumer.Listener += Consumer_Listener;
                connection.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// 消费者监听内容
        /// </summary>
        /// <param name="message"></param>
        private void Consumer_Listener(IMessage message)
        {
            try
            {
                if (SendMessageEvent != null)
                {
                    SendMessageEvent(message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion
    }
}
