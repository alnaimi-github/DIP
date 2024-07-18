using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace DIP.Container;

public class CustomContainer
{
    private readonly Dictionary<Type, Type> _iocContainer = new();

    public void Register<TFrom, TTo>(ServiceLifetime lifetime = ServiceLifetime.Transient) where TTo : TFrom
    {
        _iocContainer[typeof(TFrom)] = typeof(TTo);
    }

    public T Resolve<T>()
    {
        return (T)Resolve(typeof(T));
    }

    private object Resolve(Type t)
    {
        if (!_iocContainer.ContainsKey(t)) throw new InvalidOperationException($"Type {t.FullName} not registered");

        var type = _iocContainer[t];
        var ctor = type.GetConstructors()
            .OrderByDescending(c => c.GetParameters().Length)
            .First();

        var parameters = ctor.GetParameters();
        if (parameters.Length == 0) return Activator.CreateInstance(type)!;

        var args = new List<object>();
        foreach (var paramInfo in parameters) args.Add(Resolve(paramInfo.ParameterType));

        return ctor.Invoke(args.ToArray());
    }
}