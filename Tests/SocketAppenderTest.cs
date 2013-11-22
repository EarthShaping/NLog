using NUnit.Framework;
using NLog;
using System;

// while :; do nc -l -p 4444; done

[TestFixture]
public class SocketAppenderTest {

//    [Test]
//    public void Sends() {
//        var s = new SocketAppender(true);
//        s.Connect();
//        s.Send("Hello");
//        s.Send("World");
//    }

    [Test]
    public void Test() {
        LoggerFactory.RemoveAllAppender();
        var s = new SocketAppender(true);
        s.Connect();
        LoggerFactory.AddAppender(s.Send);
        LoggerFactory.AddAppender((message, logLevel) => Console.WriteLine(message));
        TestHelper.LogAllLogLevels(LoggerFactory.GetLogger("SocketAppender"));
    }
}


