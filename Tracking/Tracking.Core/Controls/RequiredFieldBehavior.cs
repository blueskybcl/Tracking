//------------------------------------------------------------------------------
// RequiredFieldBehavior.cs
//
// <copyright from='2005' to='2016' company='Smartware Enterprises Inc'> 
// Copyright (c) Smartware Enterprises Inc. All Rights Reserved. 
// Information Contained Herein is Proprietary and Confidential. 
// </copyright>
//
// Created: 12/21/2017
// Owner: Chonglong Bai
//
//------------------------------------------------------------------------------

using Xamarin.Forms;

namespace Zion.App.Controls.Behaviors
{
    public static class RequiredFieldBehavior
    {
        private static readonly Color NormalColor = Color.Black;
        private static readonly Color RequiredColor = Color.Red;

        public static readonly BindableProperty IsRequiredProperty =
            BindableProperty.CreateAttached(
                "IsRequired",
                typeof(bool),
                typeof(RequiredFieldBehavior),
                false,
                propertyChanged: OnIsRequiredChanged);

        public static readonly BindableProperty FieldValueProperty =
            BindableProperty.CreateAttached(
                "FieldValue",
                typeof(object),
                typeof(RequiredFieldBehavior),
                null,
                propertyChanged: OnFieldValueChanged);
        
        public static bool GetIsRequired(BindableObject view)
        {
            return (bool)view.GetValue(IsRequiredProperty);
        }

        public static void SetIsRequired(BindableObject view, bool value)
        {
            view.SetValue(IsRequiredProperty, value);
        }

        public static object GetFieldValue(BindableObject view)
        {
            return view.GetValue(FieldValueProperty);
        }

        public static void SetFieldValue(BindableObject view, object value)
        {
            view.SetValue(FieldValueProperty, value);
        }

        private static void OnIsRequiredChanged(BindableObject view, object oldValue, object newValue)
        {
            ChangeColor(view, GetIsRequired(view), GetFieldValue(view));
        }

        private static void OnFieldValueChanged(BindableObject view, object oldvalue, object newvalue)
        {
            ChangeColor(view, GetIsRequired(view), GetFieldValue(view));
        }

        private static void ChangeColor(BindableObject owner, bool isRequired, object value)
        {
            if (!(owner is Label lblTitle))
            {
                return;
            }
            
            if (isRequired && string.IsNullOrEmpty(value?.ToString()))
            {
                lblTitle.TextColor = RequiredColor;
            }
            else
            {
                lblTitle.TextColor = NormalColor;
            }
        }
    }
}
