﻿@code
    Layout = "~/Views/Shared/_Layout.vbhtml"
    ViewBag.Title = "SelectPdf Free Html To Pdf Converter for .NET - Control Page Breaks with Html to Pdf Converter - VB.NET / ASP.NET MVC"
    ViewBag.Description = "SelectPdf Free Html To Pdf Converter Control Page Breaks with Html to Pdf Converter Sample for VB.NET/ASP.NET MVC. Pdf Library for .NET with full sample code in C# and VB.NET."
    ViewBag.Keywords = "page breaks, custom page break, keep together, pdf library, sample code, html to pdf, pdf converter"
End code

@Using (Html.BeginForm("SubmitAction", "PageBreaks", FormMethod.Post))

    @<article class="post type-post status-publish format-standard hentry">
        <header class="entry-header">
            <h1 class="entry-title">SelectPdf Free Html To Pdf Converter - Control Page Breaks with Html to Pdf Converter - VB.NET / ASP.NET MVC Sample</h1>
        </header>
        <!-- .entry-header -->

        <div class="entry-content">
            <p>
                This sample shows how to use SelectPdf html to pdf converter to convert a raw html code to pdf and also how to control the page breaks from the html code.
                <br />
                <br />
                To insert a page break in pdf, the html code must have an element with the style <i>page-break-before: always</i> or <i>page-break-after: always</i>.
                Before or after that specific element, a page break will be inserted into the generated pdf document. The element can be anything (image, table, table row, div, text, etc).
                <br />
                <br />
                To instruct a certain section from the content to remain on the same page in the generated pdf document, an element with the style <i>page-break-inside: avoid</i> must be used.
            </p>
            <p>
                Html Code:<br />
                <textarea style="width: 90%; height: 150px;" name="TxtHtmlCode">@ViewData("PageBreaksValue")</textarea><br />
                <br />
                Base Url:<br />
                <input type="text" value="" name="TxtBaseUrl" style="width: 90%;" />
            </p>
            <div class="col-clear"></div>
            <p>
                <input type="submit" name="BtnConvert" value="Create PDF" class="mybutton" />
            </p>
        </div>
        <!-- .entry-content -->
    </article>
End Using
    