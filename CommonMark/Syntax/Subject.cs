﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CommonMark.Syntax
{
    [System.Diagnostics.DebuggerDisplay("{DebugToString()}")]
    internal class Subject
    {
        /// <summary>
        /// Gets or sets the whole buffer this instance is created over.
        /// </summary>
        public string Buffer;

        /// <summary>
        /// Gets or sets the current position in the buffer.
        /// </summary>
        public int Position;

        public int LabelNestingLevel;

        public Dictionary<string, Reference> ReferenceMap;

        //public Dictionary<int, Inline> Memory = new Dictionary<int,Inline>();

        private string DebugToString()
        {
            if (this.Position > this.Buffer.Length)
                return this.Buffer;

            return this.Buffer.Insert(this.Position, "⁞");
        }
    }
}
