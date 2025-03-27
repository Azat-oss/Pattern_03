using Pattern_03.TemplateMethod;
using Pattern_03.State;
using Pattern_03.Mediator;
using Pattern_03.Iterator;
using Pattern_03.Chain_of_Responsibility;
using Pattern_03.Bridge;
using Pattern_03.Flyweight;



//TemplateMethod
Console.WriteLine("");
Console.WriteLine("Pattern_03.TemplateMethod");
Console.WriteLine("");

AbstractClass classA = new ClassA();
classA.TemplateMethod();

Console.WriteLine();

AbstractClass classB = new ClassB();
classB.TemplateMethod();

//State
Console.WriteLine("");
Console.WriteLine("Pattern_03.State");
Console.WriteLine("");
// Создаем начальное состояние
var context = new Context(new StateA());

// Вызываем запрос для обработки состояния
for (int i = 0; i < 5; i++)
{
    context.Request();
}

// Mediator
Console.WriteLine("");
Console.WriteLine("Pattern_03.Mediator");
Console.WriteLine("");

ConcreteMediator mediator = new ConcreteMediator();

Colleague_1 colleague_1 = new Colleague_1(mediator);
Colleague_2 colleague_2 = new Colleague_2(mediator);

mediator.SetColleague_1(colleague_1);
mediator.SetColleague_2(colleague_2);

colleague_1.Send("Привет, Азат!");
colleague_2.Send("Привет, Роман!");

//Iterator
Console.WriteLine("");
Console.WriteLine("Pattern_03.Iterator");
Console.WriteLine("");

var collection = new ListCollection<string>();
collection.Add("Item 1");
collection.Add("Item 2");
collection.Add("Item 3");

IIterator<string> iterator = collection.CreateIterator();

while (iterator.HasNext())
{
    string item = iterator.Next();
    Console.WriteLine(item);
}

//Chain of Responsibility

Console.WriteLine("");
Console.WriteLine("Pattern_03.Chain of Responsibility");
Console.WriteLine("");

// Создаем обработчики
Handler handlerA = new HandlerA();
Handler handlerB = new HandlerB();
Handler handlerC = new HandlerC();

// Устанавливаем цепочку
handlerA.SetNext(handlerB);
handlerB.SetNext(handlerC);

// Создаем запросы
Request request1 = new Request(1);
Request request2 = new Request(2);
Request request3 = new Request(3);


// Обрабатываем запросы
handlerA.HandleRequest(request1);
handlerA.HandleRequest(request2);
handlerA.HandleRequest(request3);

// Bridge
Console.WriteLine("");
Console.WriteLine("Pattern_03.Bridge");
Console.WriteLine("");
IImplementation implementationA = new ConcreteImplementationA();
Abstraction abstractionA = new RefinedAbstraction(implementationA);
abstractionA.Operation();

IImplementation implementationB = new ConcreteImplementationB();
Abstraction abstractionB = new RefinedAbstraction(implementationB);
abstractionB.Operation();
// Flyweight
Console.WriteLine("");
Console.WriteLine("Pattern_03.Flyweight");
Console.WriteLine("");
CharacterFactory factory = new CharacterFactory();
var text = "HELLO FLYWEIGHT";

foreach (char c in text)
{
    ICharacter character = factory.GetCharacter(c, "Arial");
    character.Display(12);  
}