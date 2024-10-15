using Practice.DataContext;
using Practice.Entities;

Console.Read();

DataContext context = new DataContext();


//1
// var getAllProductsAndThereCategories = from p in context.Products
//     join c in context.Categories on p.CategoryId equals c.Id
//     select new { ProductName = p.Name, CategoryName = c.Name };
// foreach (var io in getAllProductsAndThereCategories)
// {
//     Console.WriteLine($"Product: {io.ProductName}, Category: {io.CategoryName}");
// }


//2
// var getUserAndCountOfHisOrdersByHisId= from p in context.Users
//     join o in context.Orders on p.Id equals o.UserId
//     group o by p into g
//     select new { UserId = g.Key.Id, UserName = g.Key.Username, OrderCount = g.Count() };
// foreach (var io in getUserAndCountOfHisOrdersByHisId)
// {
//     Console.WriteLine($"User: {io.UserName}, Order Count: {io.OrderCount}");
// }



//3
// var getAllCategoriesWithProductCount= from p in context.Products
//  join c in context.Categories on p.CategoryId equals c.Id
//  group p by c into g
//  select new { CategoryName = g.Key.Name, ProductCount = g.Count() };
// foreach (var io in getAllCategoriesWithProductCount)
// {
//   Console.WriteLine($"Category: {io.CategoryName}, Product Count: {io.ProductCount}");
// }

//4
// var getAllUsersAndThereOrders= from u in context.Users
//     join o in context.Orders on u.Id equals o.UserId
//     group o by u into g
//     select new
//     {
//         UserName=g.Key.Username,
//         OrdersCount=g.Count()
//     };
//
// foreach (var io in getAllUsersAndThereOrders)
// {
//     Console.WriteLine($"{io.UserName}: {io.OrdersCount} ");
// }

//5
// var getAllOrderThatSumIsMoreThan200= from o in context.Orders
//     where o.TotalAmount > 200
//     select o;
//
// foreach (var io in getAllOrderThatSumIsMoreThan200)
// {
//     Console.WriteLine($"Order Id: {io.Id}, Total Amount: {io.TotalAmount}");
// }


//6
// var findAllProductsThatAreStock= from p in context.Products
//     where p.Stock > 0
//     select p;
//
// foreach (var io in findAllProductsThatAreStock)
// {
//     Console.WriteLine($"Product Id: {io.Id}, Name: {io.Name}, Stock: {io.Stock}");
// }

//7
// var getAllOrderThatIsAfterDefinetData= from o in context.Orders
//     where o.OrderDate > DateTime.UtcNow.AddDays(-9)
//     select o;
//
// foreach (var io in getAllOrderThatIsAfterDefinetData)
// {
//     Console.WriteLine($"Order Id: {io.Id}, User Id: {io.UserId}, Order Date: {io.OrderDate}");
// }

//8
// var getAllUsersAndThereOrders= from u in context.Users
//     join o in context.Orders on u.Id equals o.UserId
//     group o by u into g
//     select new
//     {
//         UserName=g.Key.Username,
//         OrdersCount=g.Count()
//     };
//
// foreach (var io in getAllUsersAndThereOrders)
// {
//     Console.WriteLine($"{io.UserName}: {io.OrdersCount} ");
// }

//9

// var getUsersThatThereOrdersSumIsMoreThansmth= from u in context.Users
//     join o in context.Orders on u.Id equals o.UserId
//     group o by u into g
//     where g.Sum(x => x.TotalAmount) > 500
//     select new
//     {
//         UserName=g.Key.Username,
//         OrdersSum=g.Sum(x => x.TotalAmount)
//     };
//
// foreach (var io in getUsersThatThereOrdersSumIsMoreThansmth)
// {
//     Console.WriteLine($"{io.UserName}: {io.OrdersSum} ");
// }

//10
// var getOrdersAndTherePrice= from u in context.Orders 
//     join oi in context.OrderItems on u.Id equals oi.OrderId
//     join p in context.Products on oi.ProductId equals p.Id
//     orderby oi.Price descending 
//     select new
//     {
//         OrderId=u.Id,
//         ProductName=p.Name,
//         Price=oi.Price
//     };
//
// foreach (var io in getOrdersAndTherePrice)
// {
//     Console.WriteLine($"Order Id: {io.OrderId}, Product Name: {io.ProductName}, Price: {io.Price}");
// }

//11
//
// var getOrdersAndThereProducts = from o in context.Orders 
// join oi in context.OrderItems on o.Id equals oi.OrderId
// join p in context.Products on oi.ProductId equals p.Id
// group new { o, p } by new { o.Id, o.UserId } into g
// select new
// {
//     OrderId=g.Key.Id,
//     UserName=g.FirstOrDefault().o.User.Username,
//     Products=g.Select(x => x.p)
// };
//
// foreach (var io in getOrdersAndThereProducts)
// {
//     Console.WriteLine($"Order Id: {io.OrderId}, User Name: {io.UserName}");
//     foreach (var product in io.Products)
//     {
//         Console.WriteLine($"- Product Name: {product.Name}");
//     }
// }

//12

// var getListOfCategoriesAndDescriptions =from c in context.Categories
//  select new 
//  {
//    CategoryName=c.Name,
//    Description=c.Description
//  };
//  foreach (var io in getListOfCategoriesAndDescriptions)
//  {
//    Console.WriteLine($"Category Name: {io.CategoryName}, Description: {io.Description}");
//  }

//13
//  var getActiveUsers = from u in context.Users
//  join o in context.Orders on u.Id equals o.UserId
//  group u by u into g
//  where g.Count() > 0
//  select g.Key;
//  foreach (var user in getActiveUsers)
//  {
//      Console.WriteLine($"User Id: {user.Id}, User Name: {user.Username}");
//  }

//14

// var getAllProductsInOneCategory = from c in context.Categories
// join p in context.Products on c.Id equals p.CategoryId
// where c.Name == "Electronics"
// select new 
// {
//     CategoryName=c.Name,
//     ProductName=p.Name
// };

// foreach (var io in getAllProductsInOneCategory)
// {
//     System.Console.WriteLine($"{io.CategoryName}: {io.ProductName}");
// }

//15
// var findOrdersThatHaveDefineProduct = 
// from o in context.Orders
// join oi in context.OrderItems on o.Id equals oi.OrderId
// join p in context.Products on oi.ProductId equals p.Id
// where p.Name == "Laptop"
// select o;

// foreach (var order in findOrdersThatHaveDefineProduct)
// {
//     Console.WriteLine($"Order Id: {order.Id}");
// }

//16

// var getInformationAboutTheLastOrdersOfAllUsers = 
// from u in context.Users
// join o in context.Orders on u.Id equals o.UserId
// orderby o.OrderDate descending
// select new{
//     UserId=u.Id,
//     UserName=u.Username,
//     LastOrderDate=o.OrderDate,
//     LastOrderTotalAmount=o.TotalAmount
// };

// foreach (var info in getInformationAboutTheLastOrdersOfAllUsers)
// {
//     Console.WriteLine($"User Id: {info.UserId}, User Name: {info.UserName}, Last Order Date: {info.LastOrderDate}, Last Order Total Amount: {info.LastOrderTotalAmount}");
// }

//17
// var getAllAmountOfAllProducts=
// from p in context.Products
// select p;

// Console.WriteLine($"Total amount of all products: {getAllAmountOfAllProducts.Count()}");

//18
// var getInformationOfAllOrdersAndthereSumForeveryOrder=  
// from o in context.Orders
// select new
// {
//     OrderId=o.Id,
//     UserName=o.User.Username,
//     TotalAmount=o.TotalAmount
// };

// foreach (var info in getInformationOfAllOrdersAndthereSumForeveryOrder)
// {
//     Console.WriteLine($"Order Id: {info.OrderId}, User Name: {info.UserName}, Total Amount: {info.TotalAmount}");
// }

//19

// var getAllDeletedProducts= from p in context.Products
// where p.IsDeleted == true
// select p;

// foreach (var product in getAllDeletedProducts)
// {
//     Console.WriteLine($"Product Id: {product.Id}, Name: {product.Name}");
// }

//20

// var getUserThatDontOrder = from p in context.Orders
// join u in context.Users on p.UserId equals u.Id
// group u by u into g
// where g.Count() == 0
// select g.Key;

// foreach (var user in getUserThatDontOrder)
// {
//     Console.WriteLine($"User Id: {user.Id}, User Name: {user.Username}");
// }

//21

// var getProductThatWasAdded3Month = from p in context.Products
// where p.CreatedAt <= DateTime.UtcNow.AddMonths(-3)
// select p;

// foreach (var product in getProductThatWasAdded3Month)
// {
//     Console.WriteLine($"Product Id: {product.Id}, Name: {product.Name}");
// }

//22
//  **Получить список пользователей и общее количество уникальных продуктов, которые они заказали, чтобы определить разнообразие покупок.**


//  var getUserAndTheirUniqueProducts = from u in context.Users
//  join o in context.Orders on u.Id equals o.UserId
//  join oi in context.OrderItems on o.Id equals oi.OrderId
//  join p in context.Products on oi.ProductId equals p.Id
//  group p by u into g
//  select new
//  {
//      UserId=g.Key.Id,
//      UserName=g.Key.Username,
//      UniqueProductsCount=g.Distinct().Count()
//  };
//  foreach (var user in getUserAndTheirUniqueProducts)
//  {
//      Console.WriteLine($"User Id: {user.UserId}, User Name: {user.UserName}, Unique Products Count: {user.UniqueProductsCount}");
//  }

//23
//  **Составить отчет о том, сколько заказов было выполнено в каждый месяц за последний год.**

//  var getOrdersPerMonth = from o in context.Orders
//  where o.OrderDate >= DateTime.UtcNow.AddYears(-1)
//  group o by o.OrderDate.Month into g
//  select new
//  {
//      Month=g.Key,
//      OrderCount=g.Count()
//  };
//  foreach (var order in getOrdersPerMonth)
//  {
//      Console.WriteLine($"Month: {order.Month}, Order Count: {order.OrderCount}");
//  }

//24
//-   **Вывести все заказы и количество товаров в каждом заказе, чтобы проанализировать среднее количество продуктов в заказе.**


//  var getOrdersAndTheirProductsCount = from o in context.Orders

//  join oi in context.OrderItems on o.Id equals oi.OrderId
//  join p in context.Products on oi.ProductId equals p.Id
//  group new { o, p } by o into g
//  select new
//  {
//      OrderId=g.Key.Id,
//      UserName=g.Key.User.Username,
//      ProductsCount=g.Count()
//  };
//  foreach (var order in getOrdersAndTheirProductsCount)
//  {
//      Console.WriteLine($"Order Id: {order.OrderId}, User Name: {order.UserName}, Products Count: {order.ProductsCount}");
//  }

//25
//-   **Определить, какая категория имеет наибольшую общую стоимость продаж (цена * количество) и вывести ее имя.**


//  var getCategoryWithTheMostExpensiveSales = from c in context.Categories
//  join p in context.Products on c.Id equals p.CategoryId
//  join oi in context.OrderItems on p.Id equals oi.ProductId
//  join o in context.Orders on oi.OrderId equals o.Id
//  group new { c, oi } by c into g
//  select new
//  {
//      CategoryName=g.Key.Name,
//      TotalSales=g.Sum(oi => oi. * oi.Price)
//  };

//  foreach (var io in getCategoryWithTheMostExpensiveSales){
//      Console.WriteLine($"Category Name: {io.CategoryName}, Total Sales: {io.TotalSales}");
//  }
//26
// var users = from u in context.Users
// join o in context.Orders on u.Id equals o.UserId
// join oi in context.OrderItems on o.Id equals oi.OrderId 
// join p in context.Products on oi.ProductId equals p.Id
// where p.Name == "Smartphone"
// select u.Username;
// foreach (var u in users)
// {
//     Console.WriteLine(u);
// }

//27
// var users = from u in context.Users
//     join o in context.Orders on u.Id equals o.UserId
//     where o.TotalAmount > 300 && o.OrderDate > DateTime.UtcNow.AddYears(-1)
//     select u.Username;
// foreach (var u in users)
// {
//     Console.WriteLine(u);
// }

//28
// var users = from u in context.Users
//     where u.CreatedAt>DateTime.UtcNow.AddMonths(-1)
//     select u.Username;
// foreach (var u in users)
// {
//     Console.WriteLine(u);
// }

//29

//30
// var products = from order in context.Orders
//                join orderItem in context.OrderItems on order.Id equals orderItem.OrderId
//                join product in context.Products on orderItem.ProductId equals product.Id
//                group order by product into productOrders 
//                where productOrders.Count()>=10
//                select new
//                {
//                    Product = productOrders.Key.Name,
//                    OrderCount = productOrders.Count()
//                };
//
// foreach (var i in products)
// {
//     Console.WriteLine(i.Product+" "+i.OrderCount);
// }