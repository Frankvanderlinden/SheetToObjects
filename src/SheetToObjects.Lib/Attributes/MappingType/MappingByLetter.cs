﻿using System;
using SheetToObjects.Lib.Configuration.ColumnMappings;

namespace SheetToObjects.Lib.Attributes.MappingType
{
    [AttributeUsage(AttributeTargets.Property)]
    public class MappingByLetter : Attribute, IMappingAttribute
    {
        public string ColumnLetter { get;  }
        
        public MappingByLetter(string columnLetter)
        {
            ColumnLetter = columnLetter;
        }

        public void SetColumnMapping<TModel>(ColumnMappingBuilder<TModel> builder)
        {
            builder.WithColumnLetter(ColumnLetter);
        }
    }
}
