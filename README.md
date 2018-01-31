# ActiveMQ

# 前提条件： 
[1]apache-activemq-5.15.2
[2]Apache.NMS.ActiveMQ-1.7.2-bin  
 
# 启动 
  
不带安全控制方式启动 
[你的解压路径]\apache-activemq\bin\activemq.bat 
 
# 安全方式启动 
添加环境变量：            ACTIVEMQ_ENCRYPTION_PASSWORD=activemq 
[你的解压路径]\apache-activemq\bin>activemq xbean:file:../conf/activemq-security.xml 
 
# Active MQ 管理地址 
http://127.0.0.1:8161/admin/ 
添加访问"http://127.0.0.1:8161/admin/"的限制 
 
# 第一步：添加访问限制 
修改D:\apache\apache-activemq\conf\jetty.xml文件 
下面这行编码，原 
<property name="authenticate" value="true" /> 
修改为 
<property name="authenticate" value="false" /> 
 
# 第二步：修改登录用户名密码，缺省分别为admin，admin 
D:\apache\apache-activemq\conf\jetty-realm.properties 
 
用户管理(前提:以安全方式启动ActiveMQ) 
 
在[你的解压路径]\apache-activemq\conf\credentials.properties文件中修改默认的用户名密码 
在[你的解压路径]\apache-activemq\conf\activemq-security.xml文件中可以添加新的用户名 
e.g.  添加oa用户，密码同用户名。 
<authenticationUser username="oa" password="oa" groups="users,admins"/> 
 
在[你的解压路径]\apache-activemq\conf\activemq-security.xml文件中你还可以设置指定的Topic或Queue 
只能被哪些用户组read 或 write。 
