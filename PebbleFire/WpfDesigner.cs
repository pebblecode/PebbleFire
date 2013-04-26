using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;

namespace PebbleFire
{
    public static class WpfDesigner
    {
        public static bool IsInDesignMode()
        {
            DependencyProperty isInDesignModeProperty = DesignerProperties.IsInDesignModeProperty;
            return GetPropertyDefaultValueAsBool(isInDesignModeProperty);
        }

        static bool GetPropertyDefaultValueAsBool(DependencyProperty property)
        {
            DependencyPropertyDescriptor dependencyPropertyDescriptor = GetDependencyPropertyDescriptor(property);
            return GetPropertyDefaultValueAsBool(dependencyPropertyDescriptor);
        }

        static DependencyPropertyDescriptor GetDependencyPropertyDescriptor(DependencyProperty property)
        {
            return DependencyPropertyDescriptor.FromProperty(property, typeof(FrameworkElement));
        }

        static bool GetPropertyDefaultValueAsBool(DependencyPropertyDescriptor dependencyPropertyDescriptor)
        {
            return (bool)dependencyPropertyDescriptor.Metadata.DefaultValue;
        }
    }
}
