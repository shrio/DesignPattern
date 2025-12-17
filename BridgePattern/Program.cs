using BridgePattern;

// 可以分别扩展ISender 和 Notification 自由组合

// 使用email发送普通消息
var regularNotification = new RegularNotification(new EmailSender());
regularNotification.Notifiy("hello", "how are you");

// 使用sms发送紧急消息
var urgentNotification = new UrgentNotification(new SmsSender());
urgentNotification.Notifiy("Error", "something is wrong");


// 也可以结合DI，创建一个管理类，将各种组合放到管理类中，注册到容器中，使用的时候用管理类调用对应的组合后的实现