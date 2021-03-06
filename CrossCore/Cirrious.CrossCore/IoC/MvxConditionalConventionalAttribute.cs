// MvxConditionalConventionalAttribute.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using System;

namespace Cirrious.CrossCore.IoC
{
    [AttributeUsage(AttributeTargets.Class)]
    public abstract class MvxConditionalConventionalAttribute : Attribute
    {
        public abstract bool IsConditionSatisfied { get; }
    }
}