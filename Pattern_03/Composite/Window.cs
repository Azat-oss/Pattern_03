﻿using System.ComponentModel;

namespace ConsoleApp11.Composite;

public class Window : Component
{
    private List<Component> components;

    public Window()
    {
        components = new List<Component>();
    }

    public override void Add(Component component)
    {
        components.Add(component);
    }

    public override void Display()
    {
        for (int i = 0; i < components.Count; i++)
        {
            components[i].Display();
        }
    }

    public override void Remove(Component component)
    {
        components.Remove(component);
    }
}