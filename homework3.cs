using System;
using System.IO;
using System.Xml.Serialization;
class LoggerFactory
{
    public static Logger createLogger(String args)
{
    if(args.equalsIgnoreCase("db"))
{
    Logger logger=new DatabaseLogger();
    return logger;
}
    else if(args.equalsIgnoreCase("file"))
{
    Logger logger=new FileLogger();
    reurn logger;
}
    else {
        reurn null;
}
}
}