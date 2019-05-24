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
}
//test
static int main(){
    OrderDemo demo = new OrderDemo;
    OrderService.Export(demo.init());
    OrderService.Imoort();
}