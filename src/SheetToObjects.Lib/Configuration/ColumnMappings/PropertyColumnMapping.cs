﻿using System.Collections.Generic;
using SheetToObjects.Lib.Validation;

namespace SheetToObjects.Lib.Configuration.ColumnMappings
{
    internal class PropertyColumnMapping : ColumnMapping, IUseHeaderRow
    {
        public string ColumnName { get; }

        public PropertyColumnMapping(string propertyName, List<IRule> rules) : base(propertyName, rules)
        {
            ColumnName = propertyName;
            ColumnIndex = -1;
        }
        public void SetColumnIndex(int columnIndex)
        {
            ColumnIndex = columnIndex;
        }

        public override string DisplayName => ColumnName;

    }
}
