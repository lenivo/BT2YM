using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2YM
{
    // Класс Создатель/GEO объявляет фабричный метод, который должен возвращать объект класса Продукт.
    // Подклассы Создателя обычно предоставляют реализацию этого метода.
    abstract class Geo
    {
        // Обратите внимание, что Создатель может также обеспечить реализацию фабричного метода по умолчанию.
        public abstract IGeo FactoryMethod();
        // Также заметьте, что, несмотря на название, основная обязанность Создателя не заключается в создании продуктов. Обычно он содержит
        // некоторую базовую бизнес-логику, которая основана  на объектах Продуктов, возвращаемых фабричным методом.  Подклассы могут косвенно
        // изменять эту бизнес-логику, переопределяя фабричный метод и возвращая из него другой тип продукта.
        public string SomeOperation()
        {
            // Вызываем фабричный метод, чтобы получить объект-продукт.
            var product = FactoryMethod();
            // Далее, работаем с этим продуктом.
            var result = "Creator: The same creator's code has just worked with " + product.Operation();
            return result;
        }
    }
    // Интерфейс Продукта/IGeo объявляет операции, которые должны выполнять все конкретные продукты.
    public interface IGeo
    {
        string Operation();
    }
    // Конкретные Продукты/GeoGPX/GeoKML предоставляют различные реализации интерфейса Продукта.
    class GeoGPX : IGeo
    {
        public string Operation()
        {
            return "{Result of GeoGPX}";
        }
    }

    class GeoKML : IGeo
    {
        public string Operation()
        {
            return "{Result of GeoKML}";
        }
    }
    // Конкретные Создатели/CreatorGPX/CreatorKML переопределяют фабричный метод
    class CreatorGPX : Geo
    {
        // Обратите внимание, что сигнатура метода по-прежнему использует тип абстрактного продукта, хотя фактически из метода возвращается
        // конкретный продукт. Таким образом, Создатель может оставаться независимым от конкретных классов продуктов.
        public override IGeo FactoryMethod()
        {
            return new GeoGPX();
        }
    }
    class CreatorKML : Geo
    {
        public override IGeo FactoryMethod()
        {
            return new GeoKML();
        }
    }
}
