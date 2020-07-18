using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace ProductOrdering.Extensions
{
    public static class EnumExtension
    {
        public static string GetDisplayName(this Enum enumvalue)
        {
            return enumvalue.GetType().GetMember(enumvalue.ToString()).First()
                .GetCustomAttribute<DisplayAttribute>().GetName();
        }
        public static IEnumerable<T> GetValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }
    }
}
