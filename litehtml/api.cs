using System;
using System.Collections.Generic;

namespace litehtml
{
    /// <summary>
    /// Rect
    /// </summary>
    public interface Rect
    {
        int left { get; }
        int top { get; }
        int right { get; }
        int bottom { get; }
        int x { get; }
        int y { get; }
        int width { get; }
        int height { get; }
    }

    /// <summary>
    /// DocumentFragment
    /// </summary>
    public interface DocumentFragment
    {
    }

    /// <summary>
    /// DocumentType
    /// </summary>
    public interface DocumentType
    {
    }

    /// <summary>
    /// DocumentImplementation
    /// </summary>
    public class DocumentImplementation
    {
    }

    /// <summary>
    /// Console
    /// https://www.w3schools.com/jsref/obj_console.asp
    /// </summary>
    public class Console
    {
        /// <summary>
        /// Writes an error message to the console if the assertion is false
        /// </summary>
        /// <param name="assertion">The assertion.</param>
        /// <param name="message">The message.</param>
        public void assert(bool assertion, object message) => throw new NotImplementedException();

        /// <summary>
        /// Clears the console
        /// </summary>
        public void clear() => throw new NotImplementedException();

        /// <summary>
        /// Logs the number of times that this particular call to count() has been called
        /// </summary>
        /// <param name="label">The label.</param>
        public void count(string label = default) => throw new NotImplementedException();

        /// <summary>
        /// Outputs an error message to the console
        /// </summary>
        /// <param name="message">The message.</param>
        public void error(object message) => throw new NotImplementedException();

        /// <summary>
        /// Creates a new inline group in the console. This indents following console messages by an additional level, until console.groupEnd() is called
        /// </summary>
        /// <param name="label">The label.</param>
        public void group(string label = default) => throw new NotImplementedException();

        /// <summary>
        /// Creates a new inline group in the console. However, the new group is created collapsed. The user will need to use the disclosure button to expand it
        /// </summary>
        /// <param name="label">The label.</param>
        public void groupCollapsed(string label = default) => throw new NotImplementedException();

        /// <summary>
        /// Exits the current inline group in the console
        /// </summary>
        public void groupEnd() => throw new NotImplementedException();

        /// <summary>
        /// Outputs an informational message to the console
        /// </summary>
        /// <param name="message">The message.</param>
        public void info(object message) => throw new NotImplementedException();

        /// <summary>
        /// Outputs a message to the console
        /// </summary>
        /// <param name="message">The message.</param>
        public void log(object message) => throw new NotImplementedException();

        /// <summary>
        /// Displays tabular data as a table
        /// </summary>
        /// <param name="tabledata">The tabledata.</param>
        /// <param name="tablecolumns">The tablecolumns.</param>
        public void table(object tabledata, string[] tablecolumns = null) => throw new NotImplementedException();

        /// <summary>
        /// Starts a timer (can track how long an operation takes)
        /// </summary>
        /// <param name="label">The label.</param>
        public void time(string label = default) => throw new NotImplementedException();

        /// <summary>
        /// Stops a timer that was previously started by console.time()
        /// </summary>
        /// <param name="label">The label.</param>
        public void timeEnd(string label = default) => throw new NotImplementedException();

        /// <summary>
        /// Outputs a stack trace to the console
        /// </summary>
        /// <param name="label">The label.</param>
        public void trace(string label = default) => throw new NotImplementedException();

        /// <summary>
        /// Outputs a warning message to the console
        /// </summary>
        /// <param name="message">The message.</param>
        public void warn(object message) => throw new NotImplementedException();
    }

    /// <summary>
    /// Document
    /// https://www.w3schools.com/jsref/dom_obj_document.asp
    /// </summary>
    public class Document : Node
    {
        readonly document _doc;

        public Document() => _doc = (document)this;

        /// <summary>
        /// Returns the currently focused element in the document
        /// </summary>
        /// <value>
        /// The active element.
        /// </value>
        public Element activeElement => throw new NotImplementedException();

        /// <summary>
        /// Attaches an event handler to the document
        /// </summary>
        /// <param name="event">The event.</param>
        /// <param name="function">The function.</param>
        /// <param name="useCapture">if set to <c>true</c> [use capture].</param>
        public void addEventListener(string @event, string function, bool useCapture = false) => throw new NotImplementedException();

        /// <summary>
        /// Adopts a node from another document
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns></returns>
        public Node adoptNode(Node node) => throw new NotImplementedException();

        /// <summary>
        /// Returns a collection of all <a> elements in the document that have a name attribute
        /// </summary>
        /// <value>
        /// The anchors.
        /// </value>
        public HTMLCollection anchors => throw new NotImplementedException();

        /// <summary>
        /// Adds a new child node, to an element, as the last child node
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns></returns>
        public override Node appendChild(Node node) => throw new NotImplementedException(); //: Node

        /// <summary>
        /// Returns a collection of all <applet> elements in the document
        /// </summary>
        /// <value>
        /// The applets.
        /// </value>
        public HTMLCollection applets => throw new NotImplementedException();

        /// <summary>
        /// 
        /// NotSupported - Returns a NamedNodeMap of an element's attributes
        /// </summary>
        /// <value>
        /// The attributes.
        /// </value>
        public override NamedNodeMap attributes => throw new NotSupportedException(); //: Node

        /// <summary>
        /// Returns the absolute base URI of a document
        /// </summary>
        /// <value>
        /// The base URI.
        /// </value>
        public override string baseURI => throw new NotImplementedException(); //: Node

        /// <summary>
        /// Sets or returns the document's body (the <body> element)
        /// </summary>
        /// <value>
        /// The body.
        /// </value>
        public Element body { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// Returns the character encoding for the document
        /// </summary>
        /// <value>
        /// The character set.
        /// </value>
        public string characterSet => "UTF-8";

        /// <summary>
        /// Returns a collection of an element's child nodes (including text and comment nodes)
        /// </summary>
        public override NodeList<Node> childNodes => new NodeList<Node>(_doc._root._children); //: Node

        /// <summary>
        /// Clones an element
        /// </summary>
        /// <param name="deep">if set to <c>true</c> [deep].</param>
        /// <returns></returns>
        public override Node cloneNode(bool deep = false) => throw new NotImplementedException(); //: Node

        /// <summary>
        /// Closes the output stream previously opened with document.open()
        /// </summary>
        public void close() => throw new NotImplementedException();

        /// <summary>
        /// Compares the document position of two elements
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns></returns>
        public override int compareDocumentPosition(Node node) => throw new NotImplementedException(); //: Node

        /// <summary>
        /// Returns all name/value pairs of cookies in the document
        /// </summary>
        /// <value>
        /// The cookie.
        /// </value>
        public string cookie { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// Creates an attribute node
        /// </summary>
        /// <param name="attributename">The attributename.</param>
        /// <returns></returns>
        public Attr createAttribute(string attributename) => new Attr(null, attributename);

        /// <summary>
        /// Creates a Comment node with the specified text
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        public Node createComment(string text) => throw new NotImplementedException(); //: IComment

        /// <summary>
        /// Creates an empty DocumentFragment node
        /// </summary>
        /// <returns></returns>
        public DocumentFragment createDocumentFragment() => throw new NotImplementedException();

        /// <summary>
        /// Creates an Element node
        /// </summary>
        /// <param name="nodename">The nodename.</param>
        /// <returns></returns>
        public Element createElement(string nodename) => throw new NotImplementedException();

        /// <summary>
        /// Creates a new event
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public Event createEvent(string type) => throw new NotImplementedException();

        /// <summary>
        /// Creates a Text node
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        public Node createTextNode(string text) => throw new NotImplementedException(); //: IText

        /// <summary>
        /// Returns the window object associated with a document, or null if none is available.
        /// </summary>
        /// <value>
        /// The default view.
        /// </value>
        public Window defaultView => throw new NotImplementedException();

        /// <summary>
        /// Controls whether the entire document should be editable or not.
        /// </summary>
        /// <value>
        /// The design mode.
        /// </value>
        public string designMode { get => "off"; set => throw new NotSupportedException(); }

        /// <summary>
        /// Returns the Document Type Declaration associated with the document
        /// </summary>
        /// <value>
        /// The doctype.
        /// </value>
        public DocumentType doctype => throw new NotImplementedException();

        /// <summary>
        /// Returns the Document Element of the document (the <html> element)
        /// </summary>
        /// <value>
        /// The document element.
        /// </value>
        public Element documentElement => throw new NotImplementedException();

        /// <summary>
        /// Sets or returns the location of the document
        /// </summary>
        /// <value>
        /// The document URI.
        /// </value>
        public string documentURI { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// Returns the domain name of the server that loaded the document
        /// </summary>
        /// <value>
        /// The domain.
        /// </value>
        public string domain => throw new NotImplementedException();

        /// <summary>
        /// Returns a collection of all <embed> elements the document
        /// </summary>
        /// <value>
        /// The embeds.
        /// </value>
        public HTMLCollection embeds => throw new NotImplementedException();

        /// <summary>
        /// Invokes the specified clipboard operation on the element currently having focus.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <param name="showUI">if set to <c>true</c> [show UI].</param>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public bool execCommand(string command, bool showUI, object value = null) => throw new NotImplementedException();

        /// <summary>
        /// Returns the first child node of an element
        /// </summary>
        /// <value>
        /// The first child.
        /// </value>
        public override Node firstChild => _doc._root._children[0]; //: Node

        /// <summary>
        /// Returns a collection of all <form> elements in the document
        /// </summary>
        /// <value>
        /// The forms.
        /// </value>
        public HTMLCollection forms => throw new NotImplementedException();

        /// <summary>
        /// Returns the current element that is displayed in fullscreen mode
        /// </summary>
        /// <value>
        /// The fullscreen element.
        /// </value>
        public Element fullscreenElement => throw new NotImplementedException();

        /// <summary>
        /// Returns a Boolean value indicating whether the document can be viewed in fullscreen mode
        /// </summary>
        /// <returns></returns>
        public bool fullscreenEnabled() => throw new NotImplementedException();

        /// <summary>
        /// Returns the element that has the ID attribute with the specified value
        /// </summary>
        /// <param name="elementID">The element identifier.</param>
        /// <returns></returns>
        public Element getElementById(string elementID)
        {
            var elem = new css_element_selector();
            var attr = new css_attribute_selector
            {
                val = elementID,
                condition = attr_select_condition.equal,
                attribute = "id"
            };
            elem._attrs.Add(attr);
            var sel = new css_selector(elem);
            return _doc._root.select_one(sel);
        }

        /// <summary>
        /// Returns a NodeList containing all elements with the specified class name
        /// </summary>
        /// <param name="classname">The classname.</param>
        /// <returns></returns>
        public NodeList<Element> getElementsByClassName(string classname) => _doc._root.getElementsByClassName(classname);

        /// <summary>
        /// Returns a NodeList containing all elements with a specified name
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public NodeList<Element> getElementsByName(string name)
        {
            var elem = new css_element_selector();
            var attr = new css_attribute_selector
            {
                val = name,
                condition = attr_select_condition.equal,
                attribute = "name"
            };
            elem._attrs.Add(attr);
            var sel = new css_selector(elem);
            return new NodeList<Element>(_doc._root.select_all(sel));
        }

        /// <summary>
        /// Returns a NodeList containing all elements with the specified tag name
        /// </summary>
        /// <param name="tagname">The tagname.</param>
        /// <returns></returns>
        public NodeList<Element> getElementsByTagName(string tagname) => _doc._root.getElementsByTagName(tagname);

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
        public override bool hasChildNodes() => _doc._root._children.Count > 0; //: Node

        /// <summary>
        /// Returns a Boolean value indicating whether the document has focus
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance has focus; otherwise, <c>false</c>.
        /// </returns>
        public bool hasFocus() => throw new NotImplementedException();

        /// <summary>
        /// Returns the <head> element of the document
        /// </summary>
        /// <value>
        /// The head.
        /// </value>
        public Element head => throw new NotImplementedException();

        /// <summary>
        ///Returns a collection of all <img> elements in the document
        /// </summary>
        /// <value>
        /// The images.
        /// </value>
        public HTMLCollection images => throw new NotImplementedException();

        /// <summary>
        /// Returns the DOMImplementation object that handles this document
        /// </summary>
        /// <value>
        /// The implementation.
        /// </value>
        public DocumentImplementation implementation => throw new NotImplementedException();

        /// <summary>
        /// Imports a node from another document
        /// </summary>
        /// <param name="node">The node.</param>
        /// <param name="deep">if set to <c>true</c> [deep].</param>
        /// <returns></returns>
        public Node importNode(Node node, bool deep) => throw new NotImplementedException();

        /// <summary>
        /// Returns the encoding, character set, used for the document
        /// </summary>
        /// <value>
        /// The input encoding.
        /// </value>
        public string inputEncoding => "UTF-8";

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
        public override Node lastChild { get { var children = _doc._root._children; return children.Count > 0 ? children[children.Count - 1] : null; } } //: Node

        /// <summary>
        /// Returns the date and time the document was last modified
        /// </summary>
        /// <value>
        /// The last modified.
        /// </value>
        public DateTime lastModified => throw new NotImplementedException(); //: string

        /// <summary>
        /// Returns a collection of all <a> and <area> elements in the document that have a href attribute
        /// </summary>
        /// <value>
        /// The links.
        /// </value>
        public HTMLCollection links => throw new NotImplementedException();

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
        public override string nodeName => "#document"; //: Node

        /// <summary>
        /// Returns the node type of a node
        /// </summary>
        /// <value>
        /// The type of the node.
        /// </value>
        public override int nodeType => 9; //: Node

        /// <summary>
        /// Sets or returns the value of a node
        /// </summary>
        /// <value>
        /// The node value.
        /// </value>
        public override string nodeValue { get => null; set { } } //: Node

        /// <summary>
        /// Removes empty Text nodes, and joins adjacent nodes
        /// </summary>
        public override void normalize() => throw new NotImplementedException(); //: Node

        /// <summary>
        /// Opens an HTML output stream to collect output from document.write()
        /// </summary>
        /// <param name="MIMEtype">The mim etype.</param>
        /// <param name="replace">The replace.</param>
        public void open(string MIMEtype = null, string replace = null) => throw new NotImplementedException();

        /// <summary>
        /// Returns the root element (document object) for an element
        /// </summary>
        /// <value>
        /// The owner document.
        /// </value>
        public override Document ownerDocument => null; //: Node

        /// <summary>
        /// Returns the parent node of an element
        /// </summary>
        /// <value>
        /// The parent node.
        /// </value>
        public override Node parentNode => null; //: Node

        /// <summary>
        /// Returns the previous node at the same node tree level
        /// </summary>
        /// <value>
        /// The previous sibling.
        /// </value>
        public override Node previousSibling => null; //: Node

        /// <summary>
        /// Returns the first element that matches a specified CSS selector(s) in the document
        /// </summary>
        /// <param name="selectors">The selectors.</param>
        /// <returns></returns>
        public Element querySelector(string selectors) => throw new NotImplementedException();

        /// <summary>
        /// Returns a static NodeList containing all elements that matches a specified CSS selector(s) in the document
        /// </summary>
        /// <param name="selectors">The selectors.</param>
        /// <returns></returns>
        public NodeList<Element> querySelectorAll(string selectors) => throw new NotImplementedException();

        /// <summary>
        /// Returns the (loading) status of the document
        /// </summary>
        /// <value>
        /// The state of the ready.
        /// </value>
        public string readyState => throw new NotImplementedException();

        /// <summary>
        /// Returns the URL of the document that loaded the current document
        /// </summary>
        /// <value>
        /// The referrer.
        /// </value>
        public string referrer => throw new NotImplementedException();

        /// <summary>
        /// Removes a child node from an element
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns></returns>
        public override Node removeChild(Node node) => throw new NotImplementedException(); //: Node

        /// <summary>
        /// Removes an event handler from the document (that has been attached with the addEventListener() method)
        /// </summary>
        /// <param name="event">The event.</param>
        /// <param name="function">The function.</param>
        /// <param name="useCapture">if set to <c>true</c> [use capture].</param>
        public void removeEventListener(string @event, string function, bool useCapture = false) => throw new NotImplementedException();

        /// <summary>
        /// NotSupported - Renames the specified node
        /// </summary>
        /// <param name="node">The node.</param>
        /// <param name="namespaceURI">The namespace URI.</param>
        /// <param name="nodename">The nodename.</param>
        /// <returns></returns>
        public Node renameNode(Node node, string namespaceURI, string nodename) => throw new NotSupportedException();

        /// <summary>
        /// Replaces a child node in an element
        /// </summary>
        /// <param name="newnode">The newnode.</param>
        /// <param name="oldnode">The oldnode.</param>
        /// <returns></returns>
        public override Node replaceChild(Node newnode, Node oldnode) => throw new NotImplementedException(); //: Node

        /// <summary>
        /// Returns a collection of <script> elements in the document
        /// </summary>
        /// <value>
        /// The scripts.
        /// </value>
        public HTMLCollection scripts => throw new NotImplementedException();

        /// <summary>
        /// Sets or returns the textual content of a node and its descendants
        /// </summary>
        /// <value>
        /// The content of the text.
        /// </value>
        public override string textContent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); } //: Node

        /// <summary>
        /// Sets or returns the title of the document
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// Returns the full URL of the HTML document
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        public string URL => throw new NotImplementedException();

        /// <summary>
        /// Writes HTML expressions or JavaScript code to a document
        /// </summary>
        /// <param name="args">The arguments.</param>
        public void write(params object[] args) => throw new NotImplementedException();

        /// <summary>
        /// Same as write(), but adds a newline character after each statement
        /// </summary>
        /// <param name="args">The arguments.</param>
        public void writeln(params object[] args) => throw new NotImplementedException();
    }

    /// <summary>
    /// Element
    /// https://www.w3schools.com/jsref/dom_obj_all.asp
    /// </summary>
    public class Element : Node, EventTarget
    {
        readonly element _elem;
        readonly EventSystem _events = new EventSystem();

        public Element() => _elem = (element)this;

        #region Event

        public bool dispatchMouseEvent(PlatformMouseEvent platformEvent, string eventType, int detail, element relatedTarget)
        {
            //var mouseEvent = new MouseEvent(eventType, _elem._doc.windowProxy, platformEvent, detail, relatedTarget);
            var didNotSwallowEvent = true;
            //    //Debug.Assert(mouseEvent.target == null || mouseEvent.target != relatedTarget);
            //    dispatchEvent(mouseEvent);
            //    if (mouseEvent.defaultPrevented || mouseEvent.defaultHandled)
            //        didNotSwallowEvent = false;

            //    //if (mouseEvent->type() == eventNames().clickEvent && mouseEvent->detail() == 2)
            //    //{
            //    //    // Special case: If it's a double click event, we also send the dblclick event. This is not part
            //    //    // of the DOM specs, but is used for compatibility with the ondblclick="" attribute. This is treated
            //    //    // as a separate event in other DOM-compliant browsers like Firefox, and so we do the same.
            //    //    // FIXME: Is it okay that mouseEvent may have been mutated by scripts via initMouseEvent in dispatchEvent above?
            //    //    Ref<MouseEvent> doubleClickEvent = MouseEvent::create(eventNames().dblclickEvent,
            //    //        mouseEvent->bubbles() ? Event::CanBubble::Yes : Event::CanBubble::No,
            //    //        mouseEvent->cancelable() ? Event::IsCancelable::Yes : Event::IsCancelable::No,
            //    //        Event::IsComposed::Yes,
            //    //        mouseEvent->view(), mouseEvent->detail(),
            //    //        mouseEvent->screenX(), mouseEvent->screenY(), mouseEvent->clientX(), mouseEvent->clientY(),
            //    //        mouseEvent->modifierKeys(), mouseEvent->button(), mouseEvent->buttons(), mouseEvent->syntheticClickType(), relatedTarget);

            //    //    if (mouseEvent->defaultHandled())
            //    //        doubleClickEvent->setDefaultHandled();

            //    //    dispatchEvent(doubleClickEvent);
            //    //    if (doubleClickEvent->defaultHandled() || doubleClickEvent->defaultPrevented())
            //    //        return false;
            //    //}
            return didNotSwallowEvent;
        }

        //public bool dispatchWheelEvent(PlatformWheelEvent platformEvent)
        //{
        //    var @event = new WheelEvent(platformEvent, document().windowProxy());

        //    // Events with no deltas are important because they convey platform information about scroll gestures
        //    // and momentum beginning or ending. However, those events should not be sent to the DOM since some
        //    // websites will break. They need to be dispatched because dispatching them will call into the default
        //    // event handler, and our platform code will correctly handle the phase changes. Calling stopPropogation()
        //    // will prevent the event from being sent to the DOM, but will still call the default event handler.
        //    // FIXME: Move this logic into WheelEvent::create.
        //    if (!platformEvent.deltaX && !platformEvent.deltaY)
        //        @event.stopImmediatePropagation();

        //    dispatchEvent(@event);
        //    return !@event.defaultPrevented && !@event.defaultHandled;
        //}

        //public bool dispatchKeyEvent(PlatformKeyboardEvent platformEvent)
        //{
        //    var event_ = new KeyboardEvent(platformEvent, document().windowProxy());

        //    var frame = document().frame();
        //    if (frame != null)
        //        if (frame.eventHandler().accessibilityPreventsEventPropagation(event_))
        //            event_.stopImmediatePropagation();

        //    dispatchEvent(event_);
        //    return !event_.defaultPrevented && !event_.defaultHandled;
        //}

        //void dispatchFocusInEvent(string eventType, element oldFocusedElement)
        //{
        //    //Debug.Assert(eventType == eventNames().focusinEvent || eventType == eventNames().DOMFocusInEvent);
        //    dispatchScopedEvent(new FocusEvent(eventType, Event.CanBubble.Yes, Event.IsCancelable.No, document().windowProxy(), 0, oldFocusedElement));
        //}

        //void dispatchFocusOutEvent(string eventType, element newFocusedElement)
        //{
        //    //Debug.Assert(eventType == eventNames().focusoutEvent || eventType == eventNames().DOMFocusOutEvent);
        //    dispatchScopedEvent(new FocusEvent(eventType, Event.CanBubble.Yes, Event.IsCancelable.No, document().windowProxy(), 0, newFocusedElement));
        //}

        //void dispatchFocusEvent(element oldFocusedElement, FocusDirection x)
        //{
        //    var page = document().page();
        //    if (page != null)
        //        page.chrome().client().elementDidFocus(this);
        //    dispatchEvent(new FocusEvent(eventNames().focusEvent, Event.CanBubble.No, Event.IsCancelable.No, document().windowProxy(), 0, WTFMove(oldFocusedElement)));
        //}

        //void dispatchBlurEvent(element newFocusedElement)
        //{
        //    var page = document().page();
        //    if (page != null)
        //        page.chrome().client().elementDidBlur(this);
        //    dispatchEvent(new FocusEvent(eventNames().blurEvent, Event.CanBubble.No, Event.IsCancelable.No, document().windowProxy(), 0, WTFMove(newFocusedElement)));
        //}

        #endregion

        /// <summary>
        /// Gets or sets the access key.
        /// </summary>
        /// <value>
        /// The access key.
        /// </value>
        public char accessKey { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// Adds the event listener.
        /// </summary>
        /// <param name="event">The event.</param>
        /// <param name="function">The function.</param>
        /// <param name="useCapture">if set to <c>true</c> [use capture].</param>
        public void addEventListener(string @event, Action<Element> function, bool useCapture = false) => _events.addEventListener(@event, null, new EventListenerOptions { capture = useCapture });

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
        public override NamedNodeMap attributes => new NamedNodeMap(((html_tag)_elem)._attrs); //: Node

        /// <summary>
        /// Returns the absolute base URI of a node
        /// </summary>
        /// <value>
        /// The base URI.
        /// </value>
        public override string baseURI => "base"; //: Node

        /// <summary>
        /// Removes focus from an element
        /// </summary>
        public void blur() => throw new NotImplementedException();

        /// <summary>
        /// Returns the number of child elements an element has
        /// </summary>
        /// <value>
        /// The child element count.
        /// </value>
        public int childElementCount => _elem._children.Count;

        /// <summary>
        /// Returns a collection of an element's child nodes (including text and comment nodes)
        /// </summary>
        public override NodeList<Node> childNodes => new NodeList<Node>(_elem._children); //: Node

        /// <summary>
        /// Returns a collection of an element's child element (excluding text and comment nodes)
        /// </summary>
        public HTMLCollection children => new HTMLCollection(_elem._children);

        /// <summary>
        /// Returns the class name(s) of an element
        /// </summary>
        /// <value>
        /// The class list.
        /// </value>
        public DOMTokenList classList => throw new NotImplementedException();

        /// <summary>
        /// Sets or returns the value of the class attribute of an element
        /// </summary>
        /// <value>
        /// The name of the class.
        /// </value>
        public string className { get => _elem.get_attr("class"); set => _elem.set_attr("class", value); }

        /// <summary>
        /// Simulates a mouse-click on an element
        /// </summary>
        public void click() => throw new NotImplementedException();

        /// <summary>
        /// Returns the height of an element, including padding
        /// </summary>
        /// <value>
        /// The height of the client.
        /// </value>
        public int clientHeight => throw new NotImplementedException();

        /// <summary>
        /// Returns the width of the left border of an element
        /// </summary>
        /// <value>
        /// The client left.
        /// </value>
        public int clientLeft => throw new NotImplementedException();

        /// <summary>
        /// Returns the width of the top border of an element
        /// </summary>
        /// <value>
        /// The client top.
        /// </value>
        public int clientTop => throw new NotImplementedException();

        /// <summary>
        /// Returns the width of an element, including padding
        /// </summary>
        /// <value>
        /// The width of the client.
        /// </value>
        public int clientWidth => throw new NotImplementedException();

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
        /// Returns true if a node is a descendant of a node, otherwise false
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns>
        ///   <c>true</c> if [contains] [the specified node]; otherwise, <c>false</c>.
        /// </returns>
        public bool contains(Node node) => throw new NotImplementedException();

        /// <summary>
        /// Sets or returns whether the content of an element is editable or not
        /// </summary>
        /// <value>
        /// The content editable.
        /// </value>
        public string contentEditable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// Sets or returns the value of the dir attribute of an element
        /// </summary>
        /// <value>
        /// The dir.
        /// </value>
        public string dir { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// Cancels an element in fullscreen mode
        /// </summary>
        public void exitFullscreen() => throw new NotImplementedException();

        /// <summary>
        /// Returns the first child node of an element
        /// </summary>
        /// <value>
        /// The first child.
        /// </value>
        public override Node firstChild => _elem._children[0]; //: Node

        /// <summary>
        /// Returns the first child element of an element
        /// </summary>
        /// <value>
        /// The first element child.
        /// </value>
        public Element firstElementChild => _elem._children.Count > 0 ? _elem._children[0] : null;

        /// <summary>
        /// Gives focus to an element
        /// </summary>
        public void focus() => throw new NotImplementedException();

        /// <summary>
        /// Returns the specified attribute value of an element node
        /// </summary>
        /// <param name="attributename">The attributename.</param>
        /// <returns></returns>
        public string getAttribute(string attributename) => _elem.get_attr(attributename);

        /// <summary>
        /// Returns the specified attribute node
        /// </summary>
        /// <param name="attributename">The attributename.</param>
        /// <returns></returns>
        public Attr getAttributeNode(string attributename) => new Attr(((html_tag)this)._attrs, attributename);

        /// <summary>
        /// Returns the size of an element and its position relative to the viewport
        /// </summary>
        /// <returns></returns>
        public Rect getBoundingClientRect() => throw new NotImplementedException();

        /// <summary>
        /// Returns a collection of all child elements with the specified class name
        /// </summary>
        /// <param name="classname">The classname.</param>
        /// <returns></returns>
        public NodeList<Element> getElementsByClassName(string classname)
        {
            var elem = new css_element_selector();
            var attr = new css_attribute_selector
            {
                val = classname,
                condition = attr_select_condition.equal,
                attribute = "class"
            };
            elem._attrs.Add(attr);
            var sel = new css_selector(elem);
            return new NodeList<Element>(_elem.select_all(sel));
        }

        /// <summary>
        /// Returns a collection of all child elements with the specified tag name
        /// </summary>
        /// <param name="tagname">The tagname.</param>
        /// <returns></returns>
        public NodeList<Element> getElementsByTagName(string tagname)
        {
            var elem = new css_element_selector { _tag = tagname.ToLowerInvariant() };
            var sel = new css_selector(elem);
            return new NodeList<Element>(_elem.select_all(sel));
        }

        /// <summary>
        /// Returns true if an element has the specified attribute, otherwise false
        /// </summary>
        /// <param name="attributename">The attributename.</param>
        /// <returns>
        ///   <c>true</c> if the specified attributename has attribute; otherwise, <c>false</c>.
        /// </returns>
        public bool hasAttribute(string attributename) => throw new NotImplementedException();

        /// <summary>
        /// Returns true if an element has any attributes, otherwise false
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance has attributes; otherwise, <c>false</c>.
        /// </returns>
        public override bool hasAttributes() => throw new NotImplementedException();

        /// <summary>
        /// Returns true if an element has any child nodes, otherwise false
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [has child nodes]; otherwise, <c>false</c>.
        /// </returns>
        public override bool hasChildNodes() => _elem._children.Count > 0; //: Node

        /// <summary>
        /// Sets or returns the value of the id attribute of an element
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string id { get => _elem.get_attr("id"); set => _elem.set_attr("id", value); }

        /// <summary>
        /// Sets or returns the content of an element
        /// </summary>
        /// <value>
        /// The inner HTML.
        /// </value>
        public string innerHTML { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// Sets or returns the text content of a node and its descendants
        /// </summary>
        /// <value>
        /// The inner text.
        /// </value>
        public string innerText { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// Inserts a HTML element at the specified position relative to the current element
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="element">The element.</param>
        public void insertAdjacentElement(string position, Element element) => throw new NotImplementedException();

        /// <summary>
        /// Inserts a HTML formatted text at the specified position relative to the current element
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="text">The text.</param>
        public void insertAdjacentHTML(string position, string text) => throw new NotImplementedException();

        /// <summary>
        /// Inserts text into the specified position relative to the current element
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="text">The text.</param>
        public void insertAdjacentText(string position, string text) => throw new NotImplementedException();

        /// <summary>
        /// Inserts a new child node before a specified, existing, child node
        /// </summary>
        /// <param name="newnode">The newnode.</param>
        /// <param name="existingnode">The existingnode.</param>
        public Node insertBefore(Node newnode, Node existingnode) => throw new NotImplementedException();

        /// <summary>
        /// Returns true if the content of an element is editable, otherwise false
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is content editable; otherwise, <c>false</c>.
        /// </value>
        public bool isContentEditable => throw new NotImplementedException();

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
        /// Sets or returns the value of the lang attribute of an element
        /// </summary>
        /// <value>
        /// The language.
        /// </value>
        public string lang { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// Returns the last child node of an element
        /// </summary>
        /// <value>
        /// The last child.
        /// </value>
        public override Node lastChild => _elem._children.Count > 0 ? _elem._children[_elem._children.Count - 1] : null; //: Node

        /// <summary>
        /// Returns the last child element of an element
        /// </summary>
        /// <value>
        /// The last element child.
        /// </value>
        public Element lastElementChild => _elem._children.Count > 0 ? _elem._children[_elem._children.Count - 1] : null;

        /// <summary>
        /// Returns the namespace URI of an element
        /// </summary>
        /// <value>
        /// The namespace URI.
        /// </value>
        public string namespaceURI => throw new NotImplementedException();

        /// <summary>
        /// Returns the next node at the same node tree level
        /// </summary>
        /// <value>
        /// The next sibling.
        /// </value>
        public override Node nextSibling => (Node)null; //: Node

        /// <summary>
        /// Returns the next element at the same node tree level
        /// </summary>
        /// <value>
        /// The next element sibling.
        /// </value>
        public Element nextElementSibling => throw new NotImplementedException();

        /// <summary>
        /// Returns the name of a node
        /// </summary>
        /// <value>
        /// The name of the node.
        /// </value>
        public override string nodeName => throw new NotImplementedException(); //: Node

        /// <summary>
        /// Returns the node type of a node
        /// </summary>
        /// <value>
        /// The type of the node.
        /// </value>
        public override int nodeType => throw new NotImplementedException(); //: Node

        /// <summary>
        /// Sets or returns the value of a node
        /// </summary>
        /// <value>
        /// The node value.
        /// </value>
        public override string nodeValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); } //: Node

        /// <summary>
        /// Joins adjacent text nodes and removes empty text nodes in an element
        /// </summary>
        public override void normalize() => throw new NotImplementedException(); //: Node

        /// <summary>
        /// Returns the height of an element, including padding, border and scrollbar
        /// </summary>
        /// <value>
        /// The height of the offset.
        /// </value>
        public int offsetHeight => throw new NotImplementedException();

        /// <summary>
        /// Returns the horizontal offset position of an element
        /// </summary>
        /// <value>
        /// The offset left.
        /// </value>
        public int offsetLeft => throw new NotImplementedException();

        /// <summary>
        /// Returns the offset container of an element
        /// </summary>
        /// <value>
        /// The offset parent.
        /// </value>
        public Node offsetParent => throw new NotImplementedException();

        /// <summary>
        /// Returns the vertical offset position of an element
        /// </summary>
        /// <value>
        /// The offset top.
        /// </value>
        public int offsetTop => throw new NotImplementedException();

        /// <summary>
        /// Returns the width of an element, including padding, border and scrollbar
        /// </summary>
        /// <value>
        /// The width of the offset.
        /// </value>
        public int offsetWidth => throw new NotImplementedException();

        public void on(string @event, Action<Window> function) => throw new NotImplementedException();

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

        /// <summary>
        /// Returns the parent element node of an element
        /// </summary>
        /// <value>
        /// The parent element.
        /// </value>
        public Element parentElement => _elem._parent;

        /// <summary>
        /// Returns the previous node at the same node tree level
        /// </summary>
        /// <value>
        /// The previous sibling.
        /// </value>
        public override Node previousSibling => (Node)null; //: Node

        /// <summary>
        /// Returns the previous element at the same node tree level
        /// </summary>
        /// <value>
        /// The previous element sibling.
        /// </value>
        public Element previousElementSibling => throw new NotImplementedException();

        /// <summary>
        /// Returns the first child element that matches a specified CSS selector(s) of an element
        /// </summary>
        /// <param name="selectors">The selectors.</param>
        /// <returns></returns>
        public Element querySelector(string selectors) => _elem.select_one(selectors);

        /// <summary>
        /// Returns all child elements that matches a specified CSS selector(s) of an element
        /// </summary>
        /// <param name="selectors">The selectors.</param>
        /// <returns></returns>
        public NodeList<Element> querySelectorAll(string selectors) => new NodeList<Element>(_elem.select_all(selectors));

        /// <summary>
        /// Removes a specified attribute from an element
        /// </summary>
        /// <param name="attributename">The attributename.</param>
        public void removeAttribute(string attributename) => throw new NotImplementedException();

        /// <summary>
        /// Removes a specified attribute node, and returns the removed node
        /// </summary>
        /// <param name="attributenode">The attributenode.</param>
        /// <returns></returns>
        public Attr removeAttributeNode(Attr attributenode) => throw new NotImplementedException();

        /// <summary>
        /// Removes a child node from an element
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns></returns>
        public override Node removeChild(Node node) => throw new NotImplementedException(); //: Node

        /// <summary>
        /// Removes an event handler that has been attached with the addEventListener() method
        /// </summary>
        /// <param name="event">The event.</param>
        /// <param name="function">The function.</param>
        /// <param name="useCapture">if set to <c>true</c> [use capture].</param>
        public void removeEventListener(string @event, Action<Element> function, bool useCapture = false) => _events.removeEventListener(@event, null, new EventListenerOptions { capture = useCapture });

        /// <summary>
        /// Replaces a child node in an element
        /// </summary>
        /// <param name="newnode">The newnode.</param>
        /// <param name="oldnode">The oldnode.</param>
        /// <returns></returns>
        public override Node replaceChild(Node newnode, Node oldnode) => throw new NotImplementedException(); //: Node

        /// <summary>
        /// Shows an element in fullscreen mode
        /// </summary>
        public void requestFullscreen() => throw new NotImplementedException();

        /// <summary>
        /// Returns the entire height of an element, including padding
        /// </summary>
        /// <value>
        /// The height of the scroll.
        /// </value>
        public int scrollHeight => throw new NotImplementedException();

        /// <summary>
        /// Scrolls the specified element into the visible area of the browser window
        /// </summary>
        /// <param name="alignTo">The align to.</param>
        public void scrollIntoView(bool alignTo = false) => throw new NotImplementedException();

        /// <summary>
        /// Sets or returns the number of pixels an element's content is scrolled horizontally
        /// </summary>
        /// <value>
        /// The scroll left.
        /// </value>
        public int scrollLeft { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// Sets or returns the number of pixels an element's content is scrolled vertically
        /// </summary>
        /// <value>
        /// The scroll top.
        /// </value>
        public int scrollTop { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// Returns the entire width of an element, including padding
        /// </summary>
        /// <value>
        /// The width of the scroll.
        /// </value>
        public int scrollWidth => throw new NotImplementedException();

        /// <summary>
        /// Sets or changes the specified attribute, to the specified value
        /// </summary>
        /// <param name="attributename">The attributename.</param>
        /// <param name="attributevalue">The attributevalue.</param>
        public void setAttribute(string attributename, string attributevalue) => _elem.set_attr(attributename, attributevalue);

        /// <summary>
        /// Sets or changes the specified attribute node
        /// </summary>
        /// <param name="attributenode">The attributenode.</param>
        /// <returns></returns>
        public Attr setAttributeNode(Attr attributenode) => throw new NotImplementedException();

        /// <summary>
        /// Sets or returns the value of the style attribute of an element
        /// </summary>
        /// <value>
        /// The style.
        /// </value>
        public Style style => throw new NotImplementedException();

        /// <summary>
        /// Sets or returns the value of the tabindex attribute of an element
        /// </summary>
        /// <value>
        /// The index of the tab.
        /// </value>
        public string tabIndex { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// Returns the tag name of an element
        /// </summary>
        /// <value>
        /// The name of the tag.
        /// </value>
        public string tagName => _elem.get_tagName();

        /// <summary>
        /// Sets or returns the textual content of a node and its descendants
        /// </summary>
        /// <value>
        /// The content of the text.
        /// </value>
        public override string textContent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); } //: Node

        /// <summary>
        /// Sets or returns the value of the title attribute of an element
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// Converts an element to a string
        /// </summary>
        public string toString() => throw new NotImplementedException();
    }

    /// <summary>
    /// Geolocation
    /// https://www.w3schools.com/jsref/obj_geolocation.asp
    /// </summary>
    public class Geolocation
    {
        /// <summary>
        /// Returns the position and altitude of the device on Earth
        /// </summary>
        /// <value>The coordinates.</value>
        /// <exception cref="NotImplementedException"></exception>
        public object coordinates => throw new NotImplementedException();

        /// <summary>
        /// Returns the position of the concerned device at a given time
        /// </summary>
        /// <value>The position.</value>
        /// <exception cref="System.NotImplementedException"></exception>
        public object position => throw new NotImplementedException();

        /// <summary>
        /// Returns the reason of an error occurring when using the geolocating device
        /// </summary>
        /// <value>The position error.</value>
        public string positionError { get; }

        /// <summary>
        /// Describes an object containing option properties to pass as a parameter of Geolocation.getCurrentPosition() and Geolocation.watchPosition()
        /// </summary>
        /// <value>The position options.</value>
        public object positionOptions { get; }

        /// <summary>
        /// Unregister location/error monitoring handlers previously installed using Geolocation.watchPosition()
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public void clearWatch() => throw new NotImplementedException();

        /// <summary>
        /// Returns the current position of the device
        /// </summary>
        /// <returns>System.Object.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public object getCurrentPosition() => throw new NotImplementedException();

        /// <summary>
        /// Returns a watch ID value that then can be used to unregister the handler by passing it to the Geolocation.clearWatch() method
        /// </summary>
        /// <returns>System.Int32.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public int watchPosition() => throw new NotImplementedException();
    }

    /// <summary>
    /// History
    /// https://www.w3schools.com/jsref/obj_history.asp
    /// </summary>
    public interface History
    {
        /// <summary>
        /// Returns the number of URLs in the history list
        /// </summary>
        int length { get; }

        /// <summary>
        /// Loads the previous URL in the history list
        /// </summary>
        void back();

        /// <summary>
        /// Loads the next URL in the history list
        /// </summary>
        void forward();

        /// <summary>
        /// Loads the next URL in the history list
        /// </summary>
        void go(int numberURL);
    }

    /// <summary>
    /// HTMLCollection
    /// https://www.w3schools.com/jsref/dom_obj_htmlcollection.asp
    /// </summary>
    public class HTMLCollection
    {
        public HTMLCollection(IEnumerable<element> elements)
        {
        }

        /// <summary>
        /// Returns the number of elements in an HTMLCollection
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        public int length { get; }

        /// <summary>
        /// Gets the <see cref="System.Object" /> with the specified index.
        /// </summary>
        /// <value>
        /// The <see cref="System.Object" />.
        /// </value>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public Element this[int index] => null;

        /// <summary>
        /// Returns the element at the specified index in an HTMLCollection
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public Element item(int index) => null;

        /// <summary>
        /// Returns the element with the specified ID, or name, in an HTMLCollection
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public Element namedItem(string name) => null;
    }

    /// <summary>
    /// Location
    /// https://www.w3schools.com/jsref/obj_location.asp
    /// </summary>
    public interface Location
    {
        /// <summary>
        /// Sets or returns the anchor part (#) of a URL
        /// </summary>
        /// <value>
        /// The hash.
        /// </value>
        string hash { get; set; }

        /// <summary>
        /// Sets or returns the hostname and port number of a URL
        /// </summary>
        /// <value>
        /// The host.
        /// </value>
        string host { get; set; }

        /// <summary>
        /// Sets or returns the hostname of a URL
        /// </summary>
        /// <value>
        /// The hostname.
        /// </value>
        string hostname { get; set; }

        /// <summary>
        /// Sets or returns the entire URL
        /// </summary>
        /// <value>
        /// The href.
        /// </value>
        string href { get; set; }

        /// <summary>
        /// Returns the protocol, hostname and port number of a URL
        /// </summary>
        /// <value>
        /// The origin.
        /// </value>
        string origin { get; }

        /// <summary>
        /// Sets or returns the path name of a URL
        /// </summary>
        /// <value>
        /// The pathname.
        /// </value>
        string pathname { get; set; }

        /// <summary>
        /// Sets or returns the port number of a URL
        /// </summary>
        /// <value>
        /// The port.
        /// </value>
        string port { get; set; }

        /// <summary>
        /// Sets or returns the protocol of a URL
        /// </summary>
        /// <value>
        /// The protocol.
        /// </value>
        string protocol { get; set; }

        /// <summary>
        /// Sets or returns the querystring part of a URL
        /// </summary>
        /// <value>
        /// The search.
        /// </value>
        string search { get; set; }

        /// <summary>
        /// Loads a new document
        /// </summary>
        /// <param name="URL">The URL.</param>
        void assign(string URL);

        /// <summary>
        /// Reloads the current document
        /// </summary>
        /// <param name="forceGet">if set to <c>true</c> [force get].</param>
        void reload(bool forceGet = false);

        /// <summary>
        /// Replaces the current document with a new one
        /// </summary>
        /// <param name="newURL">The new URL.</param>
        void replace(string newURL);
    }

    /// <summary>
    /// MediaQueryList
    /// https://www.w3schools.com/jsref/met_win_matchmedia.asp
    /// </summary>
    public class MediaQueryList
    {
        /// <summary>
        /// Used to check the results of a query. Returns a boolean value: true if the document matches the media query list, otherwise false
        /// </summary>
        /// <value>
        /// The matches.
        /// </value>
        public object matches { get; }

        /// <summary>
        /// A String, representing the serialized media query list
        /// </summary>
        /// <value>
        /// The media.
        /// </value>
        public string media { get; }

        /// <summary>
        /// Adds a new listener function, which is executed whenever the media query's evaluated result changes
        /// </summary>
        /// <param name="functionref">The functionref.</param>
        /// <exception cref="NotImplementedException"></exception>
        public void addListener(object functionref) => throw new NotImplementedException();

        /// <summary>
        /// Removes a previously added listener function from the media query list. Does nothing if the specified listener is not already in the list
        /// </summary>
        /// <param name="functionref">The functionref.</param>
        /// <exception cref="NotImplementedException"></exception>
        public void removeListener(object functionref) => throw new NotImplementedException();
    }

    /// <summary>
    /// Navigator
    /// https://www.w3schools.com/jsref/obj_navigator.asp
    /// </summary>
    public interface Navigator
    {
        /// <summary>
        /// Returns the code name of the browser
        /// </summary>
        /// <value>
        /// The name of the application code.
        /// </value>
        string appCodeName { get; }

        /// <summary>
        /// Returns the name of the browser
        /// </summary>
        /// <value>
        /// The name of the application.
        /// </value>
        string appName { get; }

        /// <summary>
        /// Returns the version information of the browser
        /// </summary>
        /// <value>
        /// The application version.
        /// </value>
        string appVersion { get; }

        /// <summary>
        /// Determines whether cookies are enabled in the browser
        /// </summary>
        /// <value>
        ///   <c>true</c> if [cookie enabled]; otherwise, <c>false</c>.
        /// </value>
        bool cookieEnabled { get; }

        /// <summary>
        /// Returns a Geolocation object that can be used to locate the user's position
        /// </summary>
        /// <value>
        /// The geolocation.
        /// </value>
        Geolocation geolocation { get; }

        /// <summary>
        /// Returns the language of the browser
        /// </summary>
        /// <value>
        /// The language.
        /// </value>
        string language { get; }

        /// <summary>
        /// Determines whether the browser is online
        /// </summary>
        /// <value>
        ///   <c>true</c> if [on line]; otherwise, <c>false</c>.
        /// </value>
        bool onLine { get; }

        /// <summary>
        /// Returns for which platform the browser is compiled
        /// </summary>
        /// <value>
        /// The platform.
        /// </value>
        string platform { get; }

        /// <summary>
        /// Returns the engine name of the browser
        /// </summary>
        /// <value>
        /// The product.
        /// </value>
        string product { get; }

        /// <summary>
        /// Returns the user-agent header sent by the browser to the server
        /// </summary>
        /// <value>
        /// The user agent.
        /// </value>
        string userAgent { get; }

        /// <summary>
        /// Specifies whether or not the browser has Java enabled
        /// </summary>
        /// <returns></returns>
        bool javaEnabled();
    }

    /// <summary>
    /// Screen
    /// https://www.w3schools.com/jsref/obj_screen.asp
    /// </summary>
    public interface Screen
    {
        /// <summary>
        /// Returns the height of the screen (excluding the Windows Taskbar)
        /// </summary>
        /// <value>
        /// The height of the avail.
        /// </value>
        int availHeight { get; }

        /// <summary>
        /// Returns the width of the screen (excluding the Windows Taskbar)
        /// </summary>
        /// <value>
        /// The width of the avail.
        /// </value>
        int availWidth { get; }

        /// <summary>
        /// Returns the bit depth of the color palette for displaying images
        /// </summary>
        /// <value>
        /// The color depth.
        /// </value>
        int colorDepth { get; }

        /// <summary>
        /// Returns the total height of the screen
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        int height { get; }

        /// <summary>
        /// Returns the color resolution (in bits per pixel) of the screen
        /// </summary>
        /// <value>
        /// The pixel depth.
        /// </value>
        int pixelDepth { get; }

        /// <summary>
        /// Returns the total width of the screen
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        int width { get; }
    }

    /// <summary>
    /// Style
    /// https://www.w3schools.com/jsref/dom_obj_style.asp
    /// </summary>
    public interface Style
    {
        /// <summary>
        /// Sets or returns the alignment between the lines inside a flexible container when the items do not use all available space
        /// </summary>
        /// <value>The content of the align.</value>
        string alignContent { get; set; }

        /// <summary>
        /// Sets or returns the alignment for items inside a flexible container
        /// </summary>
        /// <value>
        /// The align items.
        /// </value>
        string alignItems { get; set; }

        /// <summary>
        /// Sets or returns the alignment for selected items inside a flexible container
        /// </summary>
        /// <value>
        /// The align self.
        /// </value>
        string alignSelf { get; set; }

        /// <summary>
        /// A shorthand property for all the animation properties below, except the animationPlayState property
        /// </summary>
        /// <value>
        /// The animation.
        /// </value>
        string animation { get; set; }

        /// <summary>
        /// Sets or returns when the animation will start
        /// </summary>
        /// <value>
        /// The animation delay.
        /// </value>
        string animationDelay { get; set; }

        /// <summary>
        /// Sets or returns whether or not the animation should play in reverse on alternate cycles
        /// </summary>
        /// <value>
        /// The animation direction.
        /// </value>
        string animationDirection { get; set; }

        /// <summary>
        /// Sets or returns how many seconds or milliseconds an animation takes to complete one cycle
        /// </summary>
        /// <value>
        /// The duration of the animation.
        /// </value>
        string animationDuration { get; set; }

        /// <summary>
        /// Sets or returns what values are applied by the animation outside the time it is executing
        /// </summary>
        /// <value>
        /// The animation fill mode.
        /// </value>
        string animationFillMode { get; set; }

        /// <summary>
        /// Sets or returns the number of times an animation should be played
        /// </summary>
        /// <value>
        /// The animation iteration count.
        /// </value>
        string animationIterationCount { get; set; }

        /// <summary>
        /// Sets or returns a name for the @keyframes animation
        /// </summary>
        /// <value>
        /// The name of the animation.
        /// </value>
        string animationName { get; set; }

        /// <summary>
        /// Sets or returns the speed curve of the animation
        /// </summary>
        /// <value>
        /// The animation timing function.
        /// </value>
        string animationTimingFunction { get; set; }

        /// <summary>
        /// Sets or returns whether the animation is running or paused
        /// </summary>
        /// <value>
        /// The state of the animation play.
        /// </value>
        string animationPlayState { get; set; }

        /// <summary>
        /// Sets or returns all the background properties in one declaration
        /// </summary>
        /// <value>
        /// The background.
        /// </value>
        string background { get; set; }

        /// <summary>
        /// Sets or returns whether a background-image is fixed or scrolls with the page
        /// </summary>
        /// <value>
        /// The background attachment.
        /// </value>
        string backgroundAttachment { get; set; }

        /// <summary>
        /// Sets or returns the background-color of an element
        /// </summary>
        /// <value>
        /// The color of the background.
        /// </value>
        string backgroundColor { get; set; }

        /// <summary>
        /// Sets or returns the background-image for an element
        /// </summary>
        /// <value>
        /// The background image.
        /// </value>
        string backgroundImage { get; set; }

        /// <summary>
        /// Sets or returns the starting position of a background-image
        /// </summary>
        /// <value>
        /// The background position.
        /// </value>
        string backgroundPosition { get; set; }

        /// <summary>
        /// Sets or returns how to repeat (tile) a background-image
        /// </summary>
        /// <value>
        /// The background repeat.
        /// </value>
        string backgroundRepeat { get; set; }

        /// <summary>
        /// Sets or returns the painting area of the background
        /// </summary>
        /// <value>
        /// The background clip.
        /// </value>
        string backgroundClip { get; set; }

        /// <summary>
        /// Sets or returns the positioning area of the background images
        /// </summary>
        /// <value>
        /// The background origin.
        /// </value>
        string backgroundOrigin { get; set; }

        /// <summary>
        /// Sets or returns the size of the background image
        /// </summary>
        /// <value>
        /// The size of the background.
        /// </value>
        string backgroundSize { get; set; }

        /// <summary>
        /// Sets or returns whether or not an element should be visible when not facing the screen
        /// </summary>
        /// <value>
        /// The backface visibility.
        /// </value>
        string backfaceVisibility { get; set; }

        /// <summary>
        /// Sets or returns borderWidth, borderStyle, and borderColor in one declaration
        /// </summary>
        /// <value>
        /// The border.
        /// </value>
        string border { get; set; }

        /// <summary>
        /// Sets or returns all the borderBottom properties in one declaration
        /// </summary>
        /// <value>
        /// The border bottom.
        /// </value>
        string borderBottom { get; set; }

        /// <summary>
        /// Sets or returns the color of the bottom border
        /// </summary>
        /// <value>
        /// The border bottom.
        /// </value>
        string borderBottomColor { get; set; }

        /// <summary>
        /// Sets or returns the shape of the border of the bottom-left corner
        /// </summary>
        /// <value>
        /// The border bottom.
        /// </value>
        string borderBottomLeftRadius { get; set; }

        /// <summary>
        /// Sets or returns the shape of the border of the bottom-right corner
        /// </summary>
        /// <value>
        /// The border bottom.
        /// </value>
        string borderBottomRightRadius { get; set; }

        /// <summary>
        /// Sets or returns the style of the bottom border
        /// </summary>
        /// <value>
        /// The border bottom.
        /// </value>
        string borderBottomStyle { get; set; }

        /// <summary>
        /// Sets or returns the width of the bottom border
        /// </summary>
        /// <value>
        /// The border bottom.
        /// </value>
        string borderBottomWidth { get; set; }

        /// <summary>
        /// Sets or returns whether the table border should be collapsed into a single border, or not
        /// </summary>
        /// <value>
        /// The border collapse.
        /// </value>
        string borderCollapse { get; set; }

        /// <summary>
        /// Sets or returns the color of an element's border (can have up to four values)
        /// </summary>
        /// <value>
        /// The color of the border.
        /// </value>
        string borderColor { get; set; }

        /// <summary>
        /// A shorthand property for setting or returning all the borderImage properties
        /// </summary>
        /// <value>
        /// The border image.
        /// </value>
        string borderImage { get; set; }

        /// <summary>
        /// Sets or returns the amount by which the border image area extends beyond the border box
        /// </summary>
        /// <value>
        /// The border image outset.
        /// </value>
        string borderImageOutset { get; set; }

        /// <summary>
        /// Sets or returns whether the image-border should be repeated, rounded or stretched
        /// </summary>
        /// <value>
        /// The border image repeat.
        /// </value>
        string borderImageRepeat { get; set; }

        /// <summary>
        /// Sets or returns the inward offsets of the image-border
        /// </summary>
        /// <value>
        /// The border image slice.
        /// </value>
        string borderImageSlice { get; set; }

        /// <summary>
        /// Sets or returns the image to be used as a border
        /// </summary>
        /// <value>
        /// The border image source.
        /// </value>
        string borderImageSource { get; set; }

        /// <summary>
        /// Sets or returns the widths of the image-border
        /// </summary>
        /// <value>
        /// The width of the border image.
        /// </value>
        string borderImageWidth { get; set; }

        /// <summary>
        /// Sets or returns all the borderLeft properties in one declaration
        /// </summary>
        /// <value>
        /// The border left.
        /// </value>
        string borderLeft { get; set; }

        /// <summary>
        /// Sets or returns the color of the left border
        /// </summary>
        /// <value>
        /// The color of the border left.
        /// </value>
        string borderLeftColor { get; set; }

        /// <summary>
        /// Sets or returns the style of the left border
        /// </summary>
        /// <value>
        /// The border left style.
        /// </value>
        string borderLeftStyle { get; set; }

        /// <summary>
        /// Sets or returns the width of the left border
        /// </summary>
        /// <value>
        /// The width of the border left.
        /// </value>
        string borderLeftWidth { get; set; }

        /// <summary>
        /// A shorthand property for setting or returning all the four borderRadius properties
        /// </summary>
        /// <value>
        /// The border radius.
        /// </value>
        string borderRadius { get; set; }

        /// <summary>
        /// Sets or returns all the borderRight properties in one declaration
        /// </summary>
        /// <value>
        /// The border right.
        /// </value>
        string borderRight { get; set; }

        /// <summary>
        /// Sets or returns the color of the right border
        /// </summary>
        /// <value>
        /// The color of the border right.
        /// </value>
        string borderRightColor { get; set; }

        /// <summary>
        /// Sets or returns the style of the right border
        /// </summary>
        /// <value>
        /// The border right style.
        /// </value>
        string borderRightStyle { get; set; }

        /// <summary>
        /// Sets or returns the width of the right border
        /// </summary>
        /// <value>
        /// The width of the border right.
        /// </value>
        string borderRightWidth { get; set; }

        /// <summary>
        /// Sets or returns the space between cells in a table
        /// </summary>
        /// <value>
        /// The border spacing.
        /// </value>
        string borderSpacing { get; set; }

        /// <summary>
        /// Sets or returns the style of an element's border (can have up to four values)
        /// </summary>
        /// <value>
        /// The border style.
        /// </value>
        string borderStyle { get; set; }

        /// <summary>
        /// Sets or returns all the borderTop properties in one declaration
        /// </summary>
        /// <value>
        /// The border top.
        /// </value>
        string borderTop { get; set; }

        /// <summary>
        /// Sets or returns the color of the top border
        /// </summary>
        /// <value>
        /// The color of the border top.
        /// </value>
        string borderTopColor { get; set; }

        /// <summary>
        /// Sets or returns the shape of the border of the top-left corner
        /// </summary>
        /// <value>
        /// The border top left radius.
        /// </value>
        string borderTopLeftRadius { get; set; }

        /// <summary>
        /// Sets or returns the shape of the border of the top-right corner
        /// </summary>
        /// <value>
        /// The border top right radius.
        /// </value>
        string borderTopRightRadius { get; set; }

        /// <summary>
        /// Sets or returns the style of the top border
        /// </summary>
        /// <value>
        /// The border top style.
        /// </value>
        string borderTopStyle { get; set; }

        /// <summary>
        /// Sets or returns the width of the top border
        /// </summary>
        /// <value>
        /// The width of the border top.
        /// </value>
        string borderTopWidth { get; set; }

        /// <summary>
        /// Sets or returns the width of an element's border (can have up to four values)
        /// </summary>
        /// <value>
        /// The width of the border.
        /// </value>
        string borderWidth { get; set; }

        /// <summary>
        /// Sets or returns the bottom position of a positioned element
        /// </summary>
        /// <value>
        /// The bottom.
        /// </value>
        string bottom { get; set; }

        /// <summary>
        /// Sets or returns the behaviour of the background and border of an element at page-break, or, for in-line elements, at line-break.
        /// </summary>
        /// <value>
        /// The box decoration break.
        /// </value>
        string boxDecorationBreak { get; set; }

        /// <summary>
        /// Attaches one or more drop-shadows to the box
        /// </summary>
        /// <value>
        /// The box shadow.
        /// </value>
        string boxShadow { get; set; }

        /// <summary>
        /// Allows you to define certain elements to fit an area in a certain way
        /// </summary>
        /// <value>
        /// The box sizing.
        /// </value>
        string boxSizing { get; set; }

        /// <summary>
        /// Sets or returns the position of the table caption
        /// </summary>
        /// <value>
        /// The caption side.
        /// </value>
        string captionSide { get; set; }

        /// <summary>
        /// Sets or returns the position of the element relative to floating objects
        /// </summary>
        /// <value>
        /// The clear.
        /// </value>
        string clear { get; set; }

        /// <summary>
        /// Sets or returns which part of a positioned element is visible
        /// </summary>
        /// <value>
        /// The clip.
        /// </value>
        string clip { get; set; }

        /// <summary>
        /// Sets or returns the color of the text
        /// </summary>
        /// <value>
        /// The color.
        /// </value>
        string color { get; set; }

        /// <summary>
        /// Sets or returns the number of columns an element should be divided into
        /// </summary>
        /// <value>
        /// The column count.
        /// </value>
        string columnCount { get; set; }

        /// <summary>
        /// Sets or returns how to fill columns
        /// </summary>
        /// <value>
        /// The column fill.
        /// </value>
        string columnFill { get; set; }

        /// <summary>
        /// Sets or returns the gap between the columns
        /// </summary>
        /// <value>
        /// The column gap.
        /// </value>
        string columnGap { get; set; }

        /// <summary>
        /// A shorthand property for setting or returning all the columnRule properties
        /// </summary>
        /// <value>
        /// The column rule.
        /// </value>
        string columnRule { get; set; }

        /// <summary>
        /// Sets or returns the color of the rule between columns
        /// </summary>
        /// <value>
        /// The color of the column rule.
        /// </value>
        string columnRuleColor { get; set; }

        /// <summary>
        /// Sets or returns the style of the rule between columns
        /// </summary>
        /// <value>
        /// The column rule style.
        /// </value>
        string columnRuleStyle { get; set; }

        /// <summary>
        /// Sets or returns the width of the rule between columns
        /// </summary>
        /// <value>
        /// The width of the column rule.
        /// </value>
        string columnRuleWidth { get; set; }

        /// <summary>
        /// A shorthand property for setting or returning columnWidth and columnCount
        /// </summary>
        /// <value>
        /// The columns.
        /// </value>
        string columns { get; set; }

        /// <summary>
        /// Sets or returns how many columns an element should span across
        /// </summary>
        /// <value>
        /// The column span.
        /// </value>
        string columnSpan { get; set; }

        /// <summary>
        /// Sets or returns the width of the columns
        /// </summary>
        /// <value>
        /// The width of the column.
        /// </value>
        string columnWidth { get; set; }

        /// <summary>
        /// Used with the :before and :after pseudo-elements, to insert generated content
        /// </summary>
        /// <value>
        /// The content.
        /// </value>
        string content { get; set; }

        /// <summary>
        /// Increments one or more counters
        /// </summary>
        /// <value>
        /// The counter increment.
        /// </value>
        string counterIncrement { get; set; }

        /// <summary>
        /// Creates or resets one or more counters
        /// </summary>
        /// <value>
        /// The counter reset.
        /// </value>
        string counterReset { get; set; }

        /// <summary>
        /// Sets or returns the type of cursor to display for the mouse pointer
        /// </summary>
        /// <value>
        /// The cursor.
        /// </value>
        string cursor { get; set; }

        /// <summary>
        /// Sets or returns the text direction
        /// </summary>
        /// <value>
        /// The direction.
        /// </value>
        string direction { get; set; }

        /// <summary>
        /// Sets or returns an element's display type
        /// </summary>
        /// <value>
        /// The display.
        /// </value>
        string display { get; set; }

        /// <summary>
        /// Sets or returns whether to show the border and background of empty cells, or not
        /// </summary>
        /// <value>
        /// The empty cells.
        /// </value>
        string emptyCells { get; set; }

        /// <summary>
        /// Sets or returns image filters (visual effects, like blur and saturation)
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        string filter { get; set; }

        /// <summary>
        /// Sets or returns the length of the item, relative to the rest
        /// </summary>
        /// <value>
        /// The flex.
        /// </value>
        string flex { get; set; }

        /// <summary>
        /// Sets or returns the initial length of a flexible item
        /// </summary>
        /// <value>
        /// The flex basis.
        /// </value>
        string flexBasis { get; set; }

        /// <summary>
        /// Sets or returns the direction of the flexible items
        /// </summary>
        /// <value>
        /// The flex direction.
        /// </value>
        string flexDirection { get; set; }

        /// <summary>
        /// A shorthand property for the flexDirection and the flexWrap properties
        /// </summary>
        /// <value>
        /// The flex flow.
        /// </value>
        string flexFlow { get; set; }

        /// <summary>
        /// Sets or returns how much the item will grow relative to the rest
        /// </summary>
        /// <value>
        /// The flex grow.
        /// </value>
        string flexGrow { get; set; }

        /// <summary>
        /// Sets or returns how the item will shrink relative to the rest
        /// </summary>
        /// <value>
        /// The flex shrink.
        /// </value>
        string flexShrink { get; set; }

        /// <summary>
        /// Sets or returns whether the flexible items should wrap or not
        /// </summary>
        /// <value>
        /// The flex wrap.
        /// </value>
        string flexWrap { get; set; }

        /// <summary>
        /// Sets or returns the horizontal alignment of an element
        /// </summary>
        /// <value>
        /// The CSS float.
        /// </value>
        string cssFloat { get; set; }

        /// <summary>
        /// Sets or returns fontStyle, fontVariant, fontWeight, fontSize, lineHeight, and fontFamily in one declaration
        /// </summary>
        /// <value>
        /// The font.
        /// </value>
        string font { get; set; }

        /// <summary>
        /// Sets or returns the font family for text
        /// </summary>
        /// <value>
        /// The font family.
        /// </value>
        string fontFamily { get; set; }

        /// <summary>
        /// Sets or returns the font size of the text
        /// </summary>
        /// <value>
        /// The size of the font.
        /// </value>
        string fontSize { get; set; }

        /// <summary>
        /// Sets or returns whether the style of the font is normal, italic or oblique
        /// </summary>
        /// <value>
        /// The font style.
        /// </value>
        string fontStyle { get; set; }

        /// <summary>
        /// Sets or returns whether the font should be displayed in small capital letters
        /// </summary>
        /// <value>
        /// The font variant.
        /// </value>
        string fontVariant { get; set; }

        /// <summary>
        /// Sets or returns the boldness of the font
        /// </summary>
        /// <value>
        /// The font weight.
        /// </value>
        string fontWeight { get; set; }

        /// <summary>
        /// Preserves the readability of text when font fallback occurs
        /// </summary>
        /// <value>
        /// The font size adjust.
        /// </value>
        string fontSizeAdjust { get; set; }

        /// <summary>
        /// Selects a normal, condensed, or expanded face from a font family
        /// </summary>
        /// <value>
        /// The font stretch.
        /// </value>
        string fontStretch { get; set; }

        /// <summary>
        /// Specifies whether a punctuation character may be placed outside the line box
        /// </summary>
        /// <value>
        /// The hanging punctuation.
        /// </value>
        string hangingPunctuation { get; set; }

        /// <summary>
        /// Sets or returns the height of an element
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        string height { get; set; }

        /// <summary>
        /// Sets how to split words to improve the layout of paragraphs
        /// </summary>
        /// <value>
        /// The hyphens.
        /// </value>
        string hyphens { get; set; }

        /// <summary>
        /// Provides the author the ability to style an element with an iconic equivalent
        /// </summary>
        /// <value>
        /// The icon.
        /// </value>
        string icon { get; set; }

        /// <summary>
        /// Specifies a rotation in the right or clockwise direction that a user agent applies to an image
        /// </summary>
        /// <value>
        /// The image orientation.
        /// </value>
        string imageOrientation { get; set; }

        /// <summary>
        /// Defines whether an element must create a new stacking content
        /// </summary>
        /// <value>
        /// The isolation.
        /// </value>
        string isolation { get; set; }

        /// <summary>
        /// Sets or returns the alignment between the items inside a flexible container when the items do not use all available space.
        /// </summary>
        /// <value>
        /// The content of the justify.
        /// </value>
        string justifyContent { get; set; }

        /// <summary>
        /// Sets or returns the left position of a positioned element
        /// </summary>
        /// <value>
        /// The left.
        /// </value>
        string left { get; set; }

        /// <summary>
        /// Sets or returns the space between characters in a text
        /// </summary>
        /// <value>
        /// The letter spacing.
        /// </value>
        string letterSpacing { get; set; }

        /// <summary>
        /// Sets or returns the distance between lines in a text
        /// </summary>
        /// <value>
        /// The height of the line.
        /// </value>
        string lineHeight { get; set; }

        /// <summary>
        /// Sets or returns listStyleImage, listStylePosition, and listStyleType in one declaration
        /// </summary>
        /// <value>
        /// The list style.
        /// </value>
        string listStyle { get; set; }

        /// <summary>
        /// Sets or returns an image as the list-item marker
        /// </summary>
        /// <value>
        /// The list style image.
        /// </value>
        string listStyleImage { get; set; }

        /// <summary>
        /// Sets or returns the position of the list-item marker
        /// </summary>
        /// <value>
        /// The list style position.
        /// </value>
        string listStylePosition { get; set; }

        /// <summary>
        /// Sets or returns the list-item marker type
        /// </summary>
        /// <value>
        /// The type of the list style.
        /// </value>
        string listStyleType { get; set; }

        /// <summary>
        /// Sets or returns the margins of an element (can have up to four values)
        /// </summary>
        /// <value>
        /// The margin.
        /// </value>
        string margin { get; set; }

        /// <summary>
        /// Sets or returns the bottom margin of an element
        /// </summary>
        /// <value>
        /// The margin bottom.
        /// </value>
        string marginBottom { get; set; }

        /// <summary>
        /// Sets or returns the left margin of an element
        /// </summary>
        /// <value>
        /// The margin left.
        /// </value>
        string marginLeft { get; set; }

        /// <summary>
        /// Sets or returns the right margin of an element
        /// </summary>
        /// <value>
        /// The margin right.
        /// </value>
        string marginRight { get; set; }

        /// <summary>
        /// Sets or returns the top margin of an element
        /// </summary>
        /// <value>
        /// The margin top.
        /// </value>
        string marginTop { get; set; }

        /// <summary>
        /// Sets or returns the maximum height of an element
        /// </summary>
        /// <value>
        /// The maximum height.
        /// </value>
        string maxHeight { get; set; }

        /// <summary>
        /// Sets or returns the maximum width of an element
        /// </summary>
        /// <value>
        /// The maximum width.
        /// </value>
        string maxWidth { get; set; }

        /// <summary>
        /// Sets or returns the minimum height of an element
        /// </summary>
        /// <value>
        /// The minimum height.
        /// </value>
        string minHeight { get; set; }

        /// <summary>
        /// Sets or returns the minimum width of an element
        /// </summary>
        /// <value>
        /// The minimum width.
        /// </value>
        string minWidth { get; set; }

        /// <summary>
        /// Sets or returns where to navigate when using the arrow-down navigation key
        /// </summary>
        /// <value>
        /// The nav down.
        /// </value>
        string navDown { get; set; }

        /// <summary>
        /// Sets or returns the tabbing order for an element
        /// </summary>
        /// <value>
        /// The index of the nav.
        /// </value>
        string navIndex { get; set; }

        /// <summary>
        /// Sets or returns where to navigate when using the arrow-left navigation key
        /// </summary>
        /// <value>
        /// The nav left.
        /// </value>
        string navLeft { get; set; }

        /// <summary>
        /// Sets or returns where to navigate when using the arrow-right navigation key
        /// </summary>
        /// <value>
        /// The nav right.
        /// </value>
        string navRight { get; set; }

        /// <summary>
        /// Sets or returns where to navigate when using the arrow-up navigation key
        /// </summary>
        /// <value>
        /// The nav up.
        /// </value>
        string navUp { get; set; }

        /// <summary>
        /// Specifies how the contents of a replaced element should be fitted to the box established by its used height and width
        /// </summary>
        /// <value>
        /// The object fit.
        /// </value>
        string objectFit { get; set; }

        /// <summary>
        /// Specifies the alignment of the replaced element inside its box
        /// </summary>
        /// <value>
        /// The object position.
        /// </value>
        string objectPosition { get; set; }

        /// <summary>
        /// Sets or returns the opacity level for an element
        /// </summary>
        /// <value>
        /// The opacity.
        /// </value>
        string opacity { get; set; }

        /// <summary>
        /// Sets or returns the order of the flexible item, relative to the rest
        /// </summary>
        /// <value>
        /// The order.
        /// </value>
        string order { get; set; }

        /// <summary>
        /// Sets or returns the minimum number of lines for an element that must be left at the bottom of a page when a page break occurs inside an element
        /// </summary>
        /// <value>
        /// The orphans.
        /// </value>
        string orphans { get; set; }

        /// <summary>
        /// Sets or returns all the outline properties in one declaration
        /// </summary>
        /// <value>
        /// The outline.
        /// </value>
        string outline { get; set; }

        /// <summary>
        /// Sets or returns the color of the outline around a element
        /// </summary>
        /// <value>
        /// The color of the outline.
        /// </value>
        string outlineColor { get; set; }

        /// <summary>
        /// Offsets an outline, and draws it beyond the border edge
        /// </summary>
        /// <value>
        /// The outline offset.
        /// </value>
        string outlineOffset { get; set; }

        /// <summary>
        /// Sets or returns the style of the outline around an element
        /// </summary>
        /// <value>
        /// The outline style.
        /// </value>
        string outlineStyle { get; set; }

        /// <summary>
        /// Sets or returns the width of the outline around an element
        /// </summary>
        /// <value>
        /// The width of the outline.
        /// </value>
        string outlineWidth { get; set; }

        /// <summary>
        /// Sets or returns what to do with content that renders outside the element box
        /// </summary>
        /// <value>
        /// The overflow.
        /// </value>
        string overflow { get; set; }

        /// <summary>
        /// Specifies what to do with the left/right edges of the content, if it overflows the element's content area
        /// </summary>
        /// <value>
        /// The overflow x.
        /// </value>
        string overflowX { get; set; }

        /// <summary>
        /// Specifies what to do with the top/bottom edges of the content, if it overflows the element's content area
        /// </summary>
        /// <value>
        /// The overflow y.
        /// </value>
        string overflowY { get; set; }

        /// <summary>
        /// Sets or returns the padding of an element (can have up to four values)
        /// </summary>
        /// <value>
        /// The padding.
        /// </value>
        string padding { get; set; }

        /// <summary>
        /// Sets or returns the bottom padding of an element
        /// </summary>
        /// <value>
        /// The padding bottom.
        /// </value>
        string paddingBottom { get; set; }

        /// <summary>
        /// Sets or returns the left padding of an element
        /// </summary>
        /// <value>
        /// The padding left.
        /// </value>
        string paddingLeft { get; set; }

        /// <summary>
        /// Sets or returns the right padding of an element
        /// </summary>
        /// <value>
        /// The padding right.
        /// </value>
        string paddingRight { get; set; }

        /// <summary>
        /// Sets or returns the top padding of an element
        /// </summary>
        /// <value>
        /// The padding top.
        /// </value>
        string paddingTop { get; set; }

        /// <summary>
        /// Sets or returns the page-break behavior after an element
        /// </summary>
        /// <value>
        /// The page break after.
        /// </value>
        string pageBreakAfter { get; set; }

        /// <summary>
        /// Sets or returns the page-break behavior before an element
        /// </summary>
        /// <value>
        /// The page break before.
        /// </value>
        string pageBreakBefore { get; set; }

        /// <summary>
        /// Sets or returns the page-break behavior inside an element
        /// </summary>
        /// <value>
        /// The page break inside.
        /// </value>
        string pageBreakInside { get; set; }

        /// <summary>
        /// Sets or returns the perspective on how 3D elements are viewed
        /// </summary>
        /// <value>
        /// The perspective.
        /// </value>
        string perspective { get; set; }

        /// <summary>
        /// Sets or returns the bottom position of 3D elements
        /// </summary>
        /// <value>
        /// The perspective origin.
        /// </value>
        string perspectiveOrigin { get; set; }

        /// <summary>
        /// Sets or returns the type of positioning method used for an element (static, relative, absolute or fixed)
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        string position { get; set; }

        /// <summary>
        /// Sets or returns the type of quotation marks for embedded quotations
        /// </summary>
        /// <value>
        /// The quotes.
        /// </value>
        string quotes { get; set; }

        /// <summary>
        /// Sets or returns whether or not an element is resizable by the user
        /// </summary>
        /// <value>
        /// The resize.
        /// </value>
        string resize { get; set; }

        /// <summary>
        /// Sets or returns the right position of a positioned element
        /// </summary>
        /// <value>
        /// The right.
        /// </value>
        string right { get; set; }

        /// <summary>
        /// Sets or returns the way to lay out table cells, rows, and columns
        /// </summary>
        /// <value>
        /// The table layout.
        /// </value>
        string tableLayout { get; set; }

        /// <summary>
        /// Sets or returns the length of the tab-character
        /// </summary>
        /// <value>
        /// The size of the tab.
        /// </value>
        string tabSize { get; set; }

        /// <summary>
        /// Sets or returns the horizontal alignment of text
        /// </summary>
        /// <value>
        /// The text align.
        /// </value>
        string textAlign { get; set; }

        /// <summary>
        /// Sets or returns how the last line of a block or a line right before a forced line break is aligned when text-align is "justify"
        /// </summary>
        /// <value>
        /// The text align last.
        /// </value>
        string textAlignLast { get; set; }

        /// <summary>
        /// Sets or returns the decoration of a text
        /// </summary>
        /// <value>
        /// The text decoration.
        /// </value>
        string textDecoration { get; set; }

        /// <summary>
        /// Sets or returns the color of the text-decoration
        /// </summary>
        /// <value>
        /// The color of the text decoration.
        /// </value>
        string textDecorationColor { get; set; }

        /// <summary>
        /// Sets or returns the type of line in a text-decoration
        /// </summary>
        /// <value>
        /// The text decoration line.
        /// </value>
        string textDecorationLine { get; set; }

        /// <summary>
        /// Sets or returns the style of the line in a text decoration
        /// </summary>
        /// <value>
        /// The text decoration style.
        /// </value>
        string textDecorationStyle { get; set; }

        /// <summary>
        /// Sets or returns the indentation of the first line of text
        /// </summary>
        /// <value>
        /// The text indent.
        /// </value>
        string textIndent { get; set; }

        /// <summary>
        /// Sets or returns the justification method used when text-align is "justify"
        /// </summary>
        /// <value>
        /// The text justify.
        /// </value>
        string textJustify { get; set; }

        /// <summary>
        /// Sets or returns what should happen when text overflows the containing element
        /// </summary>
        /// <value>
        /// The text overflow.
        /// </value>
        string textOverflow { get; set; }

        /// <summary>
        /// Sets or returns the shadow effect of a text
        /// </summary>
        /// <value>
        /// The text shadow.
        /// </value>
        string textShadow { get; set; }

        /// <summary>
        /// Sets or returns the capitalization of a text
        /// </summary>
        /// <value>
        /// The text transform.
        /// </value>
        string textTransform { get; set; }

        /// <summary>
        /// Sets or returns the top position of a positioned element
        /// </summary>
        /// <value>
        /// The top.
        /// </value>
        string top { get; set; }

        /// <summary>
        /// Applies a 2D or 3D transformation to an element
        /// </summary>
        /// <value>
        /// The transform.
        /// </value>
        string transform { get; set; }

        /// <summary>
        /// Sets or returns the position of transformed elements
        /// </summary>
        /// <value>
        /// The transform origin.
        /// </value>
        string transformOrigin { get; set; }

        /// <summary>
        /// Sets or returns how nested elements are rendered in 3D space
        /// </summary>
        /// <value>
        /// The transform style.
        /// </value>
        string transformStyle { get; set; }

        /// <summary>
        /// A shorthand property for setting or returning the four transition properties
        /// </summary>
        /// <value>
        /// The transition.
        /// </value>
        string transition { get; set; }

        /// <summary>
        /// Sets or returns the CSS property that the transition effect is for
        /// </summary>
        /// <value>
        /// The transition property.
        /// </value>
        string transitionProperty { get; set; }

        /// <summary>
        /// Sets or returns how many seconds or milliseconds a transition effect takes to complete
        /// </summary>
        /// <value>
        /// The duration of the transition.
        /// </value>
        string transitionDuration { get; set; }

        /// <summary>
        /// Sets or returns the speed curve of the transition effect
        /// </summary>
        /// <value>
        /// The transition timing function.
        /// </value>
        string transitionTimingFunction { get; set; }

        /// <summary>
        /// Sets or returns when the transition effect will start
        /// </summary>
        /// <value>
        /// The transition delay.
        /// </value>
        string transitionDelay { get; set; }

        /// <summary>
        /// Sets or returns whether the text should be overridden to support multiple languages in the same document
        /// </summary>
        /// <value>
        /// The unicode bidi.
        /// </value>
        string unicodeBidi { get; set; }

        /// <summary>
        /// Sets or returns whether the text of an element can be selected or not
        /// </summary>
        /// <value>
        /// The user select.
        /// </value>
        string userSelect { get; set; }

        /// <summary>
        /// Sets or returns the vertical alignment of the content in an element
        /// </summary>
        /// <value>
        /// The vertical align.
        /// </value>
        string verticalAlign { get; set; }

        /// <summary>
        /// Sets or returns whether an element should be visible
        /// </summary>
        /// <value>
        /// The visibility.
        /// </value>
        string visibility { get; set; }

        /// <summary>
        /// Sets or returns how to handle tabs, line breaks and whitespace in a text
        /// </summary>
        /// <value>
        /// The white space.
        /// </value>
        string whiteSpace { get; set; }

        /// <summary>
        /// Sets or returns the width of an element
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        string width { get; set; }

        /// <summary>
        /// Sets or returns line breaking rules for non-CJK scripts
        /// </summary>
        /// <value>
        /// The word break.
        /// </value>
        string wordBreak { get; set; }

        /// <summary>
        /// Sets or returns the spacing between words in a text
        /// </summary>
        /// <value>
        /// The word spacing.
        /// </value>
        string wordSpacing { get; set; }

        /// <summary>
        /// Allows long, unbreakable words to be broken and wrap to the next line
        /// </summary>
        /// <value>
        /// The word wrap.
        /// </value>
        string wordWrap { get; set; }

        /// <summary>
        /// Sets or returns the minimum number of lines for an element that must be visible at the top of a page
        /// </summary>
        /// <value>
        /// The widows.
        /// </value>
        string widows { get; set; }

        /// <summary>
        /// Sets or returns the stack order of a positioned element
        /// </summary>
        /// <value>
        /// The index of the z.
        /// </value>
        string zIndex { get; set; }
    }

    /// <summary>
    /// Window
    /// https://www.w3schools.com/jsref/obj_window.asp
    /// </summary>
    public class Window
    {
        /// <summary>
        /// Returns a Boolean value indicating whether a window has been closed or not
        /// </summary>
        /// <value>
        ///   <c>true</c> if closed; otherwise, <c>false</c>.
        /// </value>
        public virtual bool closed => throw new NotImplementedException();

        /// <summary>
        /// Returns a reference to the Console object, which provides methods for logging information to the browser's console (See Console object)
        /// </summary>
        /// <value>
        /// The console.
        /// </value>
        public virtual Console console { get; } = new Console();

        /// <summary>
        /// Sets or returns the default text in the statusbar of a window
        /// </summary>
        /// <value>
        /// The default status.
        /// </value>
        public virtual string defaultStatus { get; set; } = "browser";

        /// <summary>
        /// Returns the Document object for the window (See Document object)
        /// </summary>
        /// <value>
        /// The document.
        /// </value>
        public virtual Document document => throw new NotImplementedException();

        /// <summary>
        /// Returns the <iframe> element in which the current window is inserted
        /// </summary>
        /// <value>
        /// The frame element.
        /// </value>
        public virtual Element frameElement => throw new NotImplementedException();

        /// <summary>
        /// Returns all <iframe> elements in the current window
        /// </summary>
        /// <value>
        /// The frames.
        /// </value>
        public virtual IList<Element> frames => throw new NotImplementedException();

        /// <summary>
        /// Returns the History object for the window (See History object)
        /// </summary>
        /// <value>
        /// The history.
        /// </value>
        public virtual History history => throw new NotImplementedException();

        /// <summary>
        /// Returns the height of the window's content area (viewport) including scrollbars
        /// </summary>
        /// <value>
        /// The height of the inner.
        /// </value>
        public virtual int innerHeight => throw new NotImplementedException();

        /// <summary>
        /// Returns the width of a window's content area (viewport) including scrollbars
        /// </summary>
        /// <value>
        /// The width of the inner.
        /// </value>
        public virtual int innerWidth => throw new NotImplementedException();

        /// <summary>
        /// Returns the number of <iframe> elements in the current window
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        public virtual int length => throw new NotImplementedException();

        /// <summary>
        /// Allows to save key/value pairs in a web browser. Stores the data with no expiration date
        /// </summary>
        /// <value>
        /// The local storage.
        /// </value>
        public virtual Storage localStorage => throw new NotImplementedException();

        /// <summary>
        /// Returns the Location object for the window (See Location object)
        /// </summary>
        /// <value>
        /// The location.
        /// </value>
        public virtual Location location => throw new NotImplementedException();

        /// <summary>
        /// Sets or returns the name of a window
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public virtual string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// Returns the Navigator object for the window (See Navigator object)
        /// </summary>
        /// <value>
        /// The navigator.
        /// </value>
        public virtual Navigator navigator => throw new NotImplementedException();

        public virtual void on(string @event, Action<Window> function) => throw new NotImplementedException();

        /// <summary>
        /// Returns a reference to the window that created the window
        /// </summary>
        /// <value>
        /// The opener.
        /// </value>
        public virtual Window opener => throw new NotImplementedException();

        /// <summary>
        /// Returns the height of the browser window, including toolbars/scrollbars
        /// </summary>
        /// <value>
        /// The height of the outer.
        /// </value>
        public virtual int outerHeight => throw new NotImplementedException();

        /// <summary>
        /// Returns the width of the browser window, including toolbars/scrollbars
        /// </summary>
        /// <value>
        /// The width of the outer.
        /// </value>
        public virtual int outerWidth => throw new NotImplementedException();

        /// <summary>
        /// Returns the pixels the current document has been scrolled (horizontally) from the upper left corner of the window
        /// </summary>
        /// <value>
        /// The page x offset.
        /// </value>
        public virtual int pageXOffset => throw new NotImplementedException();

        /// <summary>
        /// Returns the pixels the current document has been scrolled (vertically) from the upper left corner of the window
        /// </summary>
        /// <value>
        /// The page y offset.
        /// </value>
        public virtual int pageYOffset => throw new NotImplementedException();

        /// <summary>
        /// Returns the parent window of the current window
        /// </summary>
        /// <value>
        /// The parent.
        /// </value>
        public virtual Window parent => throw new NotImplementedException();

        /// <summary>
        /// Returns the Screen object for the window (See Screen object)
        /// </summary>
        /// <value>
        /// The screen.
        /// </value>
        public virtual Screen screen => throw new NotImplementedException();

        /// <summary>
        /// Returns the horizontal coordinate of the window relative to the screen
        /// </summary>
        /// <value>
        /// The screen left.
        /// </value>
        public virtual int screenLeft => throw new NotImplementedException();

        /// <summary>
        /// Returns the vertical coordinate of the window relative to the screen
        /// </summary>
        /// <value>
        /// The screen top.
        /// </value>
        public virtual int screenTop => throw new NotImplementedException();

        /// <summary>
        /// Returns the horizontal coordinate of the window relative to the screen
        /// </summary>
        /// <value>
        /// The screen x.
        /// </value>
        public virtual int screenX => throw new NotImplementedException();

        /// <summary>
        /// Returns the vertical coordinate of the window relative to the screen
        /// </summary>
        /// <value>
        /// The screen y.
        /// </value>
        public virtual int screenY => throw new NotImplementedException();

        /// <summary>
        /// Allows to save key/value pairs in a web browser. Stores the data for one session
        /// </summary>
        /// <value>
        /// The session storage.
        /// </value>
        public virtual Storage sessionStorage => throw new NotImplementedException();

        /// <summary>
        /// An alias of pageXOffset
        /// </summary>
        /// <value>
        /// The scroll x.
        /// </value>
        public virtual int scrollX => throw new NotImplementedException();

        /// <summary>
        /// An alias of pageYOffset
        /// </summary>
        /// <value>
        /// The scroll y.
        /// </value>
        public virtual int scrollY => throw new NotImplementedException();

        /// <summary>
        /// Returns the current window
        /// </summary>
        /// <value>
        /// The self.
        /// </value>
        public virtual Window self => this;

        /// <summary>
        /// Sets or returns the text in the statusbar of a window
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public virtual string status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// Returns the topmost browser window
        /// </summary>
        /// <value>
        /// The top.
        /// </value>
        public virtual Window top => throw new NotImplementedException();

        /// <summary>
        /// Displays an alert box with a message and an OK button
        /// </summary>
        /// <param name="message">The message.</param>
        public virtual void alert(string message) => throw new NotImplementedException();

        /// <summary>
        /// Decodes a base-64 encoded string
        /// </summary>
        /// <param name="encodedStr">The encoded string.</param>
        /// <returns></returns>
        public virtual string atob(string encodedStr) => throw new NotImplementedException();

        /// <summary>
        /// Removes focus from the current window
        /// </summary>
        public virtual void blur() => throw new NotImplementedException();

        /// <summary>
        /// Encodes a string in base-64
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns></returns>
        public virtual string btoa(string str) => throw new NotImplementedException();

        /// <summary>
        /// Clears a timer set with setInterval()
        /// </summary>
        /// <param name="var">The variable.</param>
        public virtual void clearInterval(string var) => throw new NotImplementedException();

        /// <summary>
        /// Clears a timer set with setTimeout()
        /// </summary>
        /// <param name="id_of_settimeout">The identifier of settimeout.</param>
        public virtual void clearTimeout(string id_of_settimeout) => throw new NotImplementedException();

        /// <summary>
        /// Closes the current window
        /// </summary>
        public virtual void close() => throw new NotImplementedException();

        /// <summary>
        /// Displays a dialog box with a message and an OK and a Cancel button
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns></returns>
        public virtual bool confirm(string message) => throw new NotImplementedException();

        /// <summary>
        /// Sets focus to the current window
        /// </summary>
        public virtual void focus() => throw new NotImplementedException();

        /// <summary>
        /// Gets the current computed CSS styles applied to an element
        /// </summary>
        /// <param name="element">The element.</param>
        /// <param name="pseudoElement">The pseudo element.</param>
        /// <returns></returns>
        public virtual Style getComputedStyle(string element, string pseudoElement) => throw new NotImplementedException();

        /// <summary>
        /// Returns a Selection object representing the range of text selected by the user
        /// </summary>
        /// <returns></returns>
        public virtual object getSelection() => throw new NotImplementedException();

        /// <summary>
        /// Returns a MediaQueryList object representing the specified CSS media query string
        /// </summary>
        /// <param name="mediaQueryString">The media query string.</param>
        /// <returns></returns>
        public virtual MediaQueryList matchMedia(string mediaQueryString) => throw new NotImplementedException();

        /// <summary>
        /// Moves a window relative to its current position
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public virtual void moveBy(int x, int y) => throw new NotImplementedException();

        /// <summary>
        /// Moves a window to the specified position
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public virtual void moveTo(int x, int y) => throw new NotImplementedException();

        /// <summary>
        /// Opens a new browser window
        /// </summary>
        /// <param name="URL">The URL.</param>
        /// <param name="name">The name.</param>
        /// <param name="specs">The specs.</param>
        /// <param name="replace">The replace.</param>
        /// <returns></returns>
        public virtual Window open(string URL = null, string name = null, string specs = null, bool replace = true) => throw new NotImplementedException();

        /// <summary>
        /// Prints the content of the current window
        /// </summary>
        public virtual void print() => throw new NotImplementedException();

        /// <summary>
        /// Displays a dialog box that prompts the visitor for input
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="defaultText">The default text.</param>
        /// <returns></returns>
        public virtual string prompt(string text, string defaultText = null) => throw new NotImplementedException();

        /// <summary>
        /// Requests the browser to call a function to update an animation before the next repaint
        /// </summary>
        /// <returns></returns>
        public virtual object requestAnimationFrame() => throw new NotImplementedException();

        /// <summary>
        /// Resizes the window by the specified pixels
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public virtual void resizeBy(int width, int height) => throw new NotImplementedException();

        /// <summary>
        /// Resizes the window to the specified width and height
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public virtual void resizeTo(int width, int height) => throw new NotImplementedException();

        /// <summary>
        /// Scrolls the document by the specified number of pixels
        /// </summary>
        /// <param name="xnum">The xnum.</param>
        /// <param name="ynum">The ynum.</param>
        public virtual void scrollBy(int xnum, int ynum) => throw new NotImplementedException();

        /// <summary>
        /// Scrolls the document to the specified coordinates
        /// </summary>
        /// <param name="xpos">The xpos.</param>
        /// <param name="ypos">The ypos.</param>
        public virtual void scrollTo(int xpos, int ypos) => throw new NotImplementedException();

        /// <summary>
        /// Calls a function or evaluates an expression at specified intervals (in milliseconds)
        /// </summary>
        /// <param name="function">The function.</param>
        /// <param name="milliseconds">The milliseconds.</param>
        /// <param name="args">The arguments.</param>
        /// <returns></returns>
        public virtual int setInterval(string function, int milliseconds, params object[] args) => throw new NotImplementedException();

        /// <summary>
        /// Calls a function or evaluates an expression after a specified number of milliseconds
        /// </summary>
        /// <param name="function">The function.</param>
        /// <param name="milliseconds">The milliseconds.</param>
        /// <param name="args">The arguments.</param>
        /// <returns></returns>
        public virtual int setTimeout(string function, int milliseconds, params object[] args) => throw new NotImplementedException();

        /// <summary>
        /// Stops the window from loading
        /// </summary>
        public virtual void stop() => throw new NotImplementedException();
    }

    /// <summary>
    /// Storage
    /// https://www.w3schools.com/jsref/obj_storage.asp
    /// </summary>
    public interface Storage
    {
        /// <summary>
        /// Returns the name of the nth key in the storage
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        string key(int index);

        /// <summary>
        /// Returns the number of data items stored in the Storage object
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        int length { get; }

        /// <summary>
        /// Returns the value of the specified key name
        /// </summary>
        /// <param name="keyname">The keyname.</param>
        /// <returns></returns>
        string getItem(string keyname);

        /// <summary>
        /// Adds that key to the storage, or update that key's value if it already exists
        /// </summary>
        /// <param name="keyname">The keyname.</param>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        string setItem(string keyname, string value);

        /// <summary>
        /// Removes that key from the storage
        /// </summary>
        /// <param name="keyname">The keyname.</param>
        void removeItem(string keyname);

        /// <summary>
        /// Empty all key out of the storage
        /// </summary>
        void clear();
    }
}
