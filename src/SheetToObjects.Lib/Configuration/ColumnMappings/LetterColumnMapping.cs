﻿using System.Collections.Generic;
using SheetToObjects.Core;
using SheetToObjects.Lib.Validation;

namespace SheetToObjects.Lib.Configuration.ColumnMappings
{
    internal class LetterColumnMapping : ColumnMapping
    {
        public string ColumnName { get; }

        public LetterColumnMapping(string columnLetter, string propertyName, List<IRule> rules) : base(propertyName, rules)
        {
            ColumnName = columnLetter;
            ColumnIndex = columnLetter.ConvertExcelColumnNameToIndex();
        }

        public override string DisplayName => ColumnName;
    }
}
