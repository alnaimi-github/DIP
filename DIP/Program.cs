using Castle.MicroKernel.Registration;
using Castle.Windsor;
using DIP;

//var shop= GenaricIOC.CreateInstance<Shopper>();

//var c=GenaricIOC.CreateInstance<MasterCard>();


//var container = new CustomContainer();
//container.Register<ICard, MasterCard>(ServiceLifetime.Singleton);
////container.Register<ICard, VisiCard>();
//container.Register<INotifier, EmailNotifier>();
//container.Register<Shopper, Shopper>();

//var shopper = container.Resolve<Shopper>();
//shopper.Pay();

//Console.ReadLine();

var container = new WindsorContainer();
container.Register(Component.For<ICard>().ImplementedBy<MasterCard>().Named("master"));
container.Register(Component.For<ICard>().ImplementedBy<VisiCard>().Named("visi"));
container.Register(Component.For<INotifier>().ImplementedBy<EmailNotifier>());
container.Register(Component.For<Shopper>().ImplementedBy<Shopper>());

var shope = container.Resolve<Shopper>();
shope.Pay();



