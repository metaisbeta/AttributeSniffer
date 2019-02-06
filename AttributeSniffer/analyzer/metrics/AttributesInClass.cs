﻿using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AttributeSniffer.analyzer.metrics
{
    class AttributesInClass : CSharpSyntaxWalker, MetricCollector
    {
        private int numberOfAttributes { get; set; } = 0;

        public override void VisitAttribute(AttributeSyntax node)
        {
            this.numberOfAttributes++;
        }

        public string getName()
        {
            return MetricsNames.ATTRIBUTES_IN_CLASS.ToString();
        }

        public int getResult()
        {
            return this.numberOfAttributes;
        }
    }
}
