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
//对订单程序中OrderService的各个Public方法添加测试用例

//使用EF框架，将订单系统的OrderService中的增删改查方法，改为对MySQL数据库的操作，并调整原来订单系统的Winform代码，使这些操作正常工作。

//基于.Net core和EF core框架，为订单系统编写Web API，实现订单功能的增删改查等各项功能。使用Postman对Web API进行测试。

//新建对象然后调用GetTestGrp方法得到测试用例
class Test4Ordsvce(){

    private Order[] GetTestGrp(){

        int TstNber = Math.Round(10*Random());
        Order[] OrdGrp = new Order[TstNber];
        for(i = 0, i < TstNber, i++){
            OrdGrp[i] = new Order();
            OrdGrp[i].OrdID = i;
        }
        return OrdGrp;
    }
}