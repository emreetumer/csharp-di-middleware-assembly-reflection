using System.Reflection;

namespace AssemblyFundamentals.WebAPI;

public class Test : ITest // ı testi sonradan yazdım spesifilk olarak bu classı bulmak için.
{
    public string Name { get; set; } = "Emre Tümer";
    public int Age { get; set; } = 24;
    public void Method()
    {
        Console.WriteLine("I am working..");
    }
}

public class AssemblyTest
{
    public void Method()
    {
        //Buraya breakporit koyup derleyince assembly içindekileri görüyoruz.
        var assembly = Assembly.GetExecutingAssembly();
        var types = assembly
            .GetTypes()
            .Where(i =>
            i.IsClass
            && !i.IsAbstract
            && typeof(ITest).IsAssignableFrom(i)) // typelarda görünen filtreleme yapılabilir.
            ;

        foreach (var type in types)
        {
            //var instance = Activator.CreateInstance(type);
            //PropertyInfo? propertyInfo = type.GetProperty("Name");

            //if (propertyInfo is null) continue;

            //var name = propertyInfo.GetValue(instance);
            //Console.WriteLine(name);

            //propertyInfo.SetValue(instance, "Eren Tümer");
            //name = propertyInfo.GetValue(instance);
            //Console.WriteLine(name);

            //MethodInfo? methodInfo = type.GetMethod("Method");
            //if (methodInfo is null) continue;
            //methodInfo.Invoke(instance, null);

            // Bu yapıların ismi Reflection yapısı




        }
    }
}

public static class AAA
{
    // Bu classı da type görür.
}

public interface ITest;
public abstract class AbstractTest;