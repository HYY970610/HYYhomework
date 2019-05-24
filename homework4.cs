public class OrderDemo
{
    public static void main(String[] args)
{
    System.out.println("\n\t\t==========订单测试!==========\n");
        init();
}
private static void init()
{
    Order ord=new Order();
        //打印默认值!
        ord.get();
        System.out.println("\n-----------------------------------------------------\n");
        //创建商品名称并,赋值!
        int    x=1001,number[]={x++,x++,x++,x++,x++};
        int    y=24,money[]={y++,y++,y++,y++,y++,};
        String[] arr={"苹果","桔子","菠萝","香蕉","蜜桃"};
        ord.set(number,money,arr);
        //赋完值在打印!
        ord.get();
}
}
class Order
{
    private int[] number=new int[5];//订单号!
    private int[] customer=new char[5];//客户!
    private String[] arr=new String[5];//商品名称!
    void set(int[] number,int[] money,String[] arr)
    {
        this.number=number;
        this.customer=customer;
        this.arr=arr;
    }
    void get()
    {
        for (int i=0;i<arr.length ;i++ )
        {
            System.out.println("商品编号=>"+number[i]+"\t客户=>"+customer[i]+"\t商品名称=>"+arr[i]);
        }
    }
}
public class OrderService
{
    string delsql="delete from"
}

public
void doPost(HttpServletRequest
request, HttpServletResponse
response
)
throws
ServletException, IOException
{
    String
    url = null;
    Order_tableDaoImplement
    otd = new Order_tableDaoImplement();
    List < Order_table > list = otd.selectOrder_table();

    if (list.size() > 0) {
        url = "Order_tableSelectAll.jsp";
        request.setAttribute("lit", list);
    } else {
        url = "loser.jsp";
    }
    request.getRequestDispatcher(url).forward(request, response);
}
private
static
final
long
serialVersionUID = 1
L;
}
public class OrderDetails
{
    string delsql=
)
throws
ServletException, IOException
{
    doPost(request, response);
}
public
void doPost(HttpServletRequest
request, HttpServletResponse
response
)
throws
ServletException, IOException
{
    String
    url = null;
    int
    id = Integer.parseInt(request.getParameter("order_id"));

    Order_tableDao
    otd = new Order_tableDaoImplement();
    boolean
    bn = otd.deleteOrder_table(id);
    System.out.println(bn);
    if (bn) {
        url = "Order_tableSelectAllServlet";
    } else {
        url = "loser.jsp";
    }
    response.sendRedirect(url);
}
}
