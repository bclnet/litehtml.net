using System;
using System.Collections.Generic;
using System.Linq;

namespace litehtml
{
    /// <summary>
    /// Node
    /// https://www.w3schools.com/xml/dom_node.asp
    /// </summary>
    public abstract class Node
    {
        /// <summary>
        /// Adds a new child node, to an element, as the last child node
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns></returns>
        public abstract Node appendChild(Node node);

        /// <summary>
        /// Returns a NamedNodeMap of an element's attributes
        /// </summary>
        /// <value>
        /// The attributes.
        /// </value>
        public abstract NamedNodeMap attributes { get; }

        /// <summary>
        /// Returns the absolute base URI of a node
        /// </summary>
        /// <value>
        /// The base URI.
        /// </value>
        public abstract string baseURI { get; }

        /// <summary>
        /// Returns a collection of an element's child nodes (including text and comment nodes)
        /// </summary>
        public abstract NodeList<Node> childNodes { get; }

        /// <summary>
        /// Clones an element
        /// </summary>
        /// <param name="deep">if set to <c>true</c> [deep].</param>
        /// <returns></returns>
        public abstract Node cloneNode(bool deep = false);

        /// <summary>
        /// Compares the document position of two elements
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns></returns>
        public abstract int compareDocumentPosition(Node node);

        /// <summary>
        /// Returns the first child node of an element
        /// </summary>
        /// <value>
        /// The first child.
        /// </value>
        public abstract Node firstChild { get; }

        /// <summary>
        /// Returns true if the specified node has any attributes, otherwise false
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance has attributes; otherwise, <c>false</c>.
        /// </returns>
        public abstract bool hasAttributes();

        /// <summary>
        /// Returns true if an element has any child nodes, otherwise false
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [has child nodes]; otherwise, <c>false</c>.
        /// </returns>
        public abstract bool hasChildNodes();

        /// <summary>
        /// Returns true if a specified namespaceURI is the default, otherwise false
        /// </summary>
        /// <param name="namespaceURI">The namespace URI.</param>
        /// <returns>
        ///   <c>true</c> if [is default namespace] [the specified namespace URI]; otherwise, <c>false</c>.
        /// </returns>
        public abstract bool isDefaultNamespace(string namespaceURI);

        /// <summary>
        /// Checks if two elements are equal
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns>
        ///   <c>true</c> if [is equal node] [the specified node]; otherwise, <c>false</c>.
        /// </returns>
        public abstract bool isEqualNode(Node node);

        /// <summary>
        /// Checks if two elements are the same node
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns>
        ///   <c>true</c> if [is same node] [the specified node]; otherwise, <c>false</c>.
        /// </returns>
        public abstract bool isSameNode(Node node);

        /// <summary>
        /// Returns the last child node of an element
        /// </summary>
        /// <value>
        /// The last child.
        /// </value>
        public abstract Node lastChild { get; }

        /// <summary>
        /// Returns the namespace URI associated with a given prefix
        /// </summary>
        /// <param name="prefix">The prefix.</param>
        /// <returns></returns>
        public string lookupNamespaceURI(string prefix) => throw new InvalidOperationException(); //: Base

        /// <summary>
        /// Returns the prefix associated with a given namespace URI
        /// </summary>
        /// <param name="namespaceURI">The namespace URI.</param>
        /// <returns></returns>
        public string lookupPrefix(string namespaceURI) => throw new InvalidOperationException(); //: Base

        /// <summary>
        /// Returns the next node at the same node tree level
        /// </summary>
        /// <value>
        /// The next sibling.
        /// </value>
        public abstract Node nextSibling { get; }

        /// <summary>
        /// Returns the name of a node
        /// </summary>
        /// <value>
        /// The name of the node.
        /// </value>
        public abstract string nodeName { get; }

        /// <summary>
        /// Returns the node type of a node
        /// </summary>
        /// <value>
        /// The type of the node.
        /// </value>
        public abstract int nodeType { get; }

        /// <summary>
        /// Sets or returns the value of a node
        /// </summary>
        /// <value>
        /// The node value.
        /// </value>
        public abstract string nodeValue { get; set; }

        /// <summary>
        /// Joins adjacent text nodes and removes empty text nodes in an element
        /// </summary>
        public abstract void normalize();

        /// <summary>
        /// Returns the root element (document object) for an element
        /// </summary>
        /// <value>
        /// The owner document.
        /// </value>
        public abstract Document ownerDocument { get; }

        /// <summary>
        /// Returns the parent node of an element
        /// </summary>
        /// <value>
        /// The parent node.
        /// </value>
        public abstract Node parentNode { get; }

        /// <summary>
        /// Sets or returns the namespace prefix of a node
        /// </summary>
        /// <value>
        /// The prefix.
        /// </value>
        public string prefix { get => throw new InvalidOperationException(); set => throw new InvalidOperationException(); } //: Base

        /// <summary>
        /// Returns the previous node at the same node tree level
        /// </summary>
        /// <value>
        /// The previous sibling.
        /// </value>
        public abstract Node previousSibling { get; }

        /// <summary>
        /// Removes a child node from an element
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns></returns>
        public abstract Node removeChild(Node node);

        /// <summary>
        /// Replaces a child node in an element
        /// </summary>
        /// <param name="newnode">The newnode.</param>
        /// <param name="oldnode">The oldnode.</param>
        /// <returns></returns>
        public abstract Node replaceChild(Node newnode, Node oldnode);

        /// <summary>
        /// Sets or returns the textual content of a node and its descendants
        /// </summary>
        /// <value>
        /// The content of the text.
        /// </value>
        public abstract string textContent { get; set; }
    }

    /// <summary>
    /// Attr
    /// https://www.w3schools.com/jsref/dom_obj_attributes.asp
    /// </summary>
    /// <seealso cref="litehtml.Node" />
    public class Attr : Node
    {
        readonly Dictionary<string, string> _attrs;
        readonly string _name;

        public Attr(Dictionary<string, string> attrs, string name)
        {
            _attrs = attrs;
            _name = name;
        }

        /// <summary>
        /// Adds a new child node, to an element, as the last child node
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns></returns>
        public override Node appendChild(Node node) => throw new NotImplementedException(); //: Node

        /// <summary>
        /// Returns a NamedNodeMap of an element's attributes
        /// </summary>
        /// <value>
        /// The attributes.
        /// </value>
        public override NamedNodeMap attributes => NamedNodeMap.Empty; //: Node

        /// <summary>
        /// Returns the absolute base URI of a node
        /// </summary>
        /// <value>
        /// The base URI.
        /// </value>
        public override string baseURI => "base"; //: Node

        /// <summary>
        /// Returns a collection of an element's child nodes (including text and comment nodes)
        /// </summary>
        public override NodeList<Node> childNodes => new NodeList<Node>(); //: Node

        /// <summary>
        /// Clones an element
        /// </summary>
        /// <param name="deep">if set to <c>true</c> [deep].</param>
        /// <returns></returns>
        public override Node cloneNode(bool deep = false) => throw new NotImplementedException(); //: Node

        /// <summary>
        /// Compares the document position of two elements
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns></returns>
        public override int compareDocumentPosition(Node node) => throw new NotImplementedException(); //: Node

        /// <summary>
        /// Returns the first child node of an element
        /// </summary>
        /// <value>
        /// The first child.
        /// </value>
        public override Node firstChild => null; //: Node

        /// <summary>
        /// Not Supported - Returns true if the specified node has any attributes, otherwise false
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance has attributes; otherwise, <c>false</c>.
        /// </returns>
        public override bool hasAttributes() => throw new NotSupportedException(); //: Node

        /// <summary>
        /// Returns true if an element has any child nodes, otherwise false
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [has child nodes]; otherwise, <c>false</c>.
        /// </returns>
        public override bool hasChildNodes() => false; //: Node

        /// <summary>
        /// Returns true if a specified namespaceURI is the default, otherwise false
        /// </summary>
        /// <param name="namespaceURI">The namespace URI.</param>
        /// <returns>
        ///   <c>true</c> if [is default namespace] [the specified namespace URI]; otherwise, <c>false</c>.
        /// </returns>
        public override bool isDefaultNamespace(string namespaceURI) => throw new NotImplementedException(); //: Node

        /// <summary>
        /// Checks if two elements are equal
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns>
        ///   <c>true</c> if [is equal node] [the specified node]; otherwise, <c>false</c>.
        /// </returns>
        public override bool isEqualNode(Node node) => throw new NotImplementedException(); //: Node

        /// <summary>
        /// Checks if two elements are the same node
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns>
        ///   <c>true</c> if [is same node] [the specified node]; otherwise, <c>false</c>.
        /// </returns>
        public override bool isSameNode(Node node) => throw new NotImplementedException(); //: Node

        /// <summary>
        /// Returns the last child node of an element
        /// </summary>
        /// <value>
        /// The last child.
        /// </value>
        public override Node lastChild => null; //: Node

        ///// <summary>
        ///// Returns the namespace URI associated with a given prefix
        ///// </summary>
        ///// <param name="prefix">The prefix.</param>
        ///// <returns></returns>
        //public override string lookupNamespaceURI(string prefix) => throw new NotImplementedException(); //: Node

        ///// <summary>
        ///// Returns the prefix associated with a given namespace URI
        ///// </summary>
        ///// <param name="namespaceURI">The namespace URI.</param>
        ///// <returns></returns>
        //public override string lookupPrefix(string namespaceURI) => throw new NotImplementedException(); //: Node

        /// <summary>
        /// Returns the next node at the same node tree level
        /// </summary>
        /// <value>
        /// The next sibling.
        /// </value>
        public override Node nextSibling => null; //: Node

        /// <summary>
        /// Returns the name of a node
        /// </summary>
        /// <value>
        /// The name of the node.
        /// </value>
        public override string nodeName => _name; //: Node

        /// <summary>
        /// Returns the node type of a node
        /// </summary>
        /// <value>
        /// The type of the node.
        /// </value>
        public override int nodeType => 2; //: Node

        /// <summary>
        /// Sets or returns the value of a node
        /// </summary>
        /// <value>
        /// The node value.
        /// </value>
        public override string nodeValue { get => _attrs[_name]; set => _attrs[_name] = value; } //: Node

        /// <summary>
        /// Joins adjacent text nodes and removes empty text nodes in an element
        /// </summary>
        public override void normalize() => throw new NotImplementedException(); //: Node

        /// <summary>
        /// Returns the root element (document object) for an element
        /// </summary>
        /// <value>
        /// The owner document.
        /// </value>
        public override Document ownerDocument => throw new NotImplementedException(); //: Node

        /// <summary>
        /// Returns the parent node of an element
        /// </summary>
        /// <value>
        /// The parent node.
        /// </value>
        public override Node parentNode => throw new NotImplementedException(); //: Node

        ///// <summary>
        ///// Sets or returns the namespace prefix of a node
        ///// </summary>
        ///// <value>
        ///// The prefix.
        ///// </value>
        //public override string prefix { get => throw new NotImplementedException(); set => throw new NotImplementedException(); } //: Node

        /// <summary>
        /// Returns the previous node at the same node tree level
        /// </summary>
        /// <value>
        /// The previous sibling.
        /// </value>
        public override Node previousSibling => null; //: Node

        /// <summary>
        /// Removes a child node from an element
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns></returns>
        public override Node removeChild(Node node) => throw new NotImplementedException(); //: Node

        /// <summary>
        /// Replaces a child node in an element
        /// </summary>
        /// <param name="newnode">The newnode.</param>
        /// <param name="oldnode">The oldnode.</param>
        /// <returns></returns>
        public override Node replaceChild(Node newnode, Node oldnode) => throw new NotImplementedException(); //: Node

        /// <summary>
        /// Sets or returns the textual content of a node and its descendants
        /// </summary>
        /// <value>
        /// The content of the text.
        /// </value>
        public override string textContent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); } //: Node

        /// <summary>
        /// Returns the name of an attribute
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string name => _name;

        /// <summary>
        /// Sets or returns the value of the attribute
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public string value { get => _attrs[_name]; set => _attrs[_name] = value; }

        /// <summary>
        /// Returns true if the attribute has been specified, otherwise it returns false
        /// </summary>
        /// <value>
        ///   <c>true</c> if specified; otherwise, <c>false</c>.
        /// </value>
        public bool specified => _attrs[_name] != null;
    }

    /// <summary>
    /// NodeList&gt;TNode&lt;
    /// https://www.w3schools.com/xml/dom_nodelist.asp
    /// https://www.w3schools.com/js/js_htmldom_nodelist.asp
    /// </summary>
    public class NodeList<TNode> where TNode : Node
    {
        readonly IList<element> items;
        public NodeList() { }
        public NodeList(IList<element> elements) => items = elements;
        public TNode this[int index] => (TNode)(Node)items?[index];
        public TNode item(int index) => (TNode)(Node)items?[index];
        public int length => items?.Count ?? 0;
    }

    /// <summary>
    /// NamedNodeMap
    /// </summary>
    public struct NamedNodeMap
    {
        public static readonly NamedNodeMap Empty = new NamedNodeMap();
        readonly Dictionary<string, string> _attrs;

        public NamedNodeMap(Dictionary<string, string> attrs) => _attrs = attrs;

        /// <summary>
        /// Returns a specified attribute node from a NamedNodeMap
        /// </summary>
        public Attr getNamedItem(string nodename) => _attrs.ContainsKey(nodename) ? new Attr(_attrs, nodename) : null;

        /// <summary>
        /// Gets the <see cref="Node"/> with the specified index.
        /// </summary>
        /// <value>
        /// The <see cref="Node"/>.
        /// </value>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public Attr this[int index] => index < _attrs.Count ? new Attr(_attrs, _attrs.Keys.ElementAt(index)) : null;

        /// <summary>
        /// Returns the attribute node at a specified index in a NamedNodeMap
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public Attr item(int index) => index < _attrs.Count ? new Attr(_attrs, _attrs.Keys.ElementAt(index)) : null;

        /// <summary>
        /// Returns the number of attribute nodes in a NamedNodeMap
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        public int length => _attrs.Count;

        /// <summary>
        /// Removes a specified attribute node
        /// </summary>
        /// <param name="nodename">The nodename.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Attr removeNamedItem(string nodename)
        {
            if (!_attrs.TryGetValue(nodename, out var value))
                throw new KeyNotFoundException(nodename);
            _attrs.Remove(nodename);
            return new Attr(_attrs, nodename);
        }

        /// <summary>
        /// Sets the specified attribute node (by name)
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Attr setNamedItem(Attr node)
        {
            var r = _attrs.TryGetValue(node.name, out var value) ? new Attr(_attrs, node.name) : null;
            _attrs[node.name] = node.value;
            return r;
        }
    }

    /// <summary>
    /// DOMTokenList
    /// </summary>
    public class DOMTokenList
    {
        /// <summary>
        /// Returns the number of classes in the list.
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        public int length { get; }

        /// <summary>
        /// Returns a collection of an element's child nodes (including text and comment nodes)
        /// </summary>
        /// <param name="classes">The classes.</param>
        public void add(params string[] classes) { }

        /// <summary>
        /// Returns a Boolean value, indicating whether an element has the specified class name.
        /// </summary>
        /// <param name="class">The class.</param>
        /// <returns>
        ///   <c>true</c> if [contains] [the specified class]; otherwise, <c>false</c>.
        /// </returns>
        public bool contains(string @class) => false;

        /// <summary>
        /// Returns the class name with a specified index number from an element
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public string item(int index) => null;

        /// <summary>
        /// Removes one or more class names from an element.
        /// </summary>
        /// <param name="classes">The classes.</param>
        public void remove(params string[] classes) { }

        /// <summary>
        /// Toggles between a class name for an element.
        /// </summary>
        /// <param name="class">The class.</param>
        /// <param name="value">if set to <c>true</c> [value].</param>
        public void toggle(string @class, bool? value = null) { }
    }
}
