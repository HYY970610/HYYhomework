using System;
using System.IO;
using System.Xml.Serialization;
class OrderDemo{
    static void Main(){
        Console.Write("\n\t\t==========订单测试!==========\n");
        init();
    }
    static Order init(){
        Order  ord = new Order();
        ord.get();
        Console.Write("\n-----------------------------------------------------\n");
        //
        int x = 1001;
        int[] number = {x++,x++,x++,x++,x++};
        int y = 24;
        int[] money = {y++,y++,y++,y++,y++,};
        string[] arr = {"苹果","桔子","菠萝","香蕉","蜜桃"};
        ord.set(number,money,arr);
        //
        ord.get();
        return Order;
    }
}

class Order{
    [XmlAttribute("number")]
    int[] number = new int[5];
    [XmlAttribute("customer")]
    int[] customer = new char[5];
    [XmlAttribute("arr")]
    string[] arr = new string[5];
    [XmlAttribute("OrdID")]
     int OrdID;
    void set(int[] number, int[] money, string[] arr){
        this.number = number;
        this.customer = customer;
        this.arr = arr;
    }
    void get(){
        for(int i = 0; i<arr.Length; i++){
            Console.Write("商品编号=>"+number[i]+"\t客户=>"+customer[i]+"\t商品名称=>"+arr[i]);
        }
    }
}

class OrderService{
    void Export(Order order){
    XmlSerializer ser = new XmlSerializer(typeof(Order));  
    TextWriter w = new StreamWriter("demo.xml");
    //
    ser.Serialize(Console.Out, order);
    Console.Read();  
    ser.Serialize(w, order);
    w.Close();
    Console.Write("message -> demo.xml : Done");
    }

    void Import(){
        StringReader rdr = new StringReader("demo.xml");
        XmlSerializer ser = new XmlSerializer(typeof(Order));
        Order ord = (Order)ser.Deserialize(rdr);
        ord.get();
    }
    bool Equals(Order ord1, Order ord2){
        if(ord1.OrdID == ord2.OrdID){
            return 1;
        }else{
            return 0;
        }
    }
    void IComparable(Order ord[]){
        int [] srt1;
        for(i=0,i<ord.Length,i++){
            srt1[i] = ord[i].OrdID;
        }
        srt1 = sort(srt1);
       for(i=0,i<ord.Length,i++){
            t = srt1[i];
            Console.Write(ord[t]);
        }
    }

}
class OrderDetails{
    
    void ToString(Order ord){
        return "number:"+ord.number+"\n customer:"+ord.customer+"\n arr:"+ord.arr;
    }
}
//test
static int main(){
    OrderDemo demo = new OrderDemo;
    OrderService.Export(demo.init());
    OrderService.Imoort();
    List<Order> OrderList = (from s instu orderby s.stuNOdescending select s).ToList<Order>();
}


//写一个订单管理的控制台程序，能够实现添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户等字段进行查询）功能。在订单删除、修改失败时，能够产生异常并显示给客户错误信息。
//提示：需要写Order（订单）、OrderDetails（订单明细），OrderService（订单服务）几个类，订单数据可以保存在OrderService中一个List中。
//
//写Equals方法，确保添加的订单不重复，每个订单的订单明细不重复。
//为订单、订单明细、客户、货物等类添加ToString方法，用来显示订单信息。
//为订单实现IComparable接口，实现按照订单号给订单排序。
//使用Lambda表达式实现订单按照订单总金额排序的功能。
//
//1、使用LINQ语言实现OrderService中的查询算法。
//2、在OrderService中添加一个Export方法，可以将所有的订单序列化为XML文件；添加一个Import方法可以从XML文件中载入订单。
