using System.Collections.Generic;
using System.Xml;


namespace Composite.C1Console.Forms
{
    /// <summary>    
    /// </summary>
    /// <exclude />
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)] 
    public class FormDefinition
    {
        /// <exclude />
        public FormDefinition(XmlReader formMarkup, Dictionary<string, object> bindings)
        {
            this.FormMarkup = formMarkup;
            this.Bindings = bindings;
        }

        /// <exclude />
        public XmlReader FormMarkup { get; private set; }

        /// <exclude />
        public Dictionary<string, object> Bindings { get; private set; }
    }
}