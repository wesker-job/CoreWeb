#pragma checksum "C:\Users\acer\source\repos\CoreWeb\CoreWeb\Views\TodoItem\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55a5debd082fc9f665696003b86abb744d4971e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TodoItem_Index), @"mvc.1.0.view", @"/Views/TodoItem/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\acer\source\repos\CoreWeb\CoreWeb\Views\_ViewImports.cshtml"
using CoreWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\acer\source\repos\CoreWeb\CoreWeb\Views\_ViewImports.cshtml"
using CoreWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55a5debd082fc9f665696003b86abb744d4971e8", @"/Views/TodoItem/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ccaa0bb7c2237ad0e2193309f82bddc35d0c1ac", @"/Views/_ViewImports.cshtml")]
    public class Views_TodoItem_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreWeb.ViewModel.TodoItemsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\acer\source\repos\CoreWeb\CoreWeb\Views\TodoItem\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <h3>Add</h3>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55a5debd082fc9f665696003b86abb744d4971e84531", async() => {
                WriteLiteral("\r\n            <input type=\"text\" id=\"addname\" name=\"addname\" placeholder=\"New to-do\" />\r\n            <input type=\"submit\" value=\"add\" />\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n<hr />\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Is Complete?</th>\r\n        <th>Name</th>\r\n        <th></th>\r\n        <th></th>\r\n    </tr>\r\n    <tbody id=\"todos\">\r\n");
#nullable restore
#line 25 "C:\Users\acer\source\repos\CoreWeb\CoreWeb\Views\TodoItem\Index.cshtml"
         foreach (var item in Model.todoItems)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\acer\source\repos\CoreWeb\CoreWeb\Views\TodoItem\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsComplete));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\acer\source\repos\CoreWeb\CoreWeb\Views\TodoItem\Index.cshtml"
           Write(Html.DisplayFor(modelItem => @item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55a5debd082fc9f665696003b86abb744d4971e87155", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\acer\source\repos\CoreWeb\CoreWeb\Views\TodoItem\Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55a5debd082fc9f665696003b86abb744d4971e89314", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "C:\Users\acer\source\repos\CoreWeb\CoreWeb\Views\TodoItem\Index.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "C:\Users\acer\source\repos\CoreWeb\CoreWeb\Views\TodoItem\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n\r\n</table>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        $().ready(function () {
            $(""#todos a"").click(function (evt) {
                evt.preventDefault();
                let href = $(this).attr(""href"");
                var hrefs = href.split('/');
                var trline = $(this).closest(""tr"").find(""td"");

                if ($(this).text() == ""Edit"") {
                    $(""#edit_id"").val(hrefs[3]);
                    $(""#edit_href"").val(hrefs[1] + ""/"" + hrefs[2]);
                    $(""#edit_name"").val(trline.eq(1).html());
                    $(""#edit_isComplete"").prop(""checked"", trline.eq(0).find(""input:checkbox"").is("":checked""));
                }
                else if ($(this).text() == ""Delete"") {
                    if (confirm(""確定要刪除編號"" + hrefs[3] + ""("" + trline.eq(1).html() + "")嗎?"")) {
                        $(""#del_id"").val(hrefs[3]);
                        console.log($(""#del_id"").val());
                        $(""#delSave"").click();
                    }
       ");
                WriteLiteral(@"             //Todo
                }
            });

            //$(""#"").click(function (evt) {
            //    evt.preventDefault();

            //    var editData = {};
            //    editData.id = $(""#edit-id"").val();
            //    editData.name = $(""#edit-name"").val();
            //    editData.isComplete = $(""#edit-isComplete"").is("":checked"");

            //    $.post($(""#edit-href"").val(), editData, function (data, status) {
            //        alert(""Data: "" + data + ""\nStatus: "" + status);
            //    });
            //});

        });

        const uri = 'https://localhost:44377/api/TodoItems';
        let todos = [];

        function getItems() {
            fetch(uri)
                .then(response => response.json())
                .then(data => _displayItems(data))
                .catch(error => console.error('Unable to get items.', error))
        }

        function addItem() {
            const addNameTextbox = document.getElementById('a");
                WriteLiteral(@"dd-name');

            const item = {
                isComplete: false,
                name: addNameTextbox.value.trim()
            };

            fetch(uri, {
                method: 'POST',
                headers: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(item)
            })
                .then(response => response.json())
                .then(() => {
                    getItems();
                    addNameTextbox.value = '';
                })
                .catch(error => console.error('Unable to add item.', error));
        }


        function deleteItem(id) {
            fetch(`${uri}/${id}`, {
                method: 'DELETE'
            })
                .then(() => getItems())
                .catch(error => console.err('Unable to delete Item.', error));
        }

        function displayEditForm(id) {
            const item = todo");
                WriteLiteral(@"s.find(item => item.id === id);

            $(""#edit-name"").val(item.name);
            $('#edit-id').val(item.id);
            $(""#edit-isComplete"").checked(item.isComplete);
            //$('#editForm').style.display = 'block';
        }

        function updateItem() {
            const itemId = document.getElementById('edit-id').value;
            const item = {
                id: parseInt(itemId, 10),
                isComplete: document.getElementById('edit-isComplete').checked,
                name: document.getElementById('edit-name').value.trim()
            };

            fetch(`${uri}/${itemId}`, {
                method: 'PUT',
                headers: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(item)
            })
                .then(() => getItems())
                .catch(error => console.error('Unable to update item.', error));

            clo");
                WriteLiteral(@"seInput();

            return false;
        }

        function closeInput() {
            document.getElementById('editForm').style.display = 'none';
        }

        function _displayCount(itemCount) {
            const name = (itemCount === 1) ? 'to-do' : 'to-dos';

            document.getElementById('counter').innerText = `${itemCount} ${name}`;
        }

        function _displayItems(data) {
            const tBody = document.getElementById('todos');
            tBody.innerHTML = '';

            _displayCount(data.length);

            const button = document.createElement('button');

            data.forEach(item => {
                let isCompleteCheckbox = document.createElement('input');
                isCompleteCheckbox.type = 'checkbox';
                isCompleteCheckbox.disabled = true;
                isCompleteCheckbox.checked = item.isComplete;

                let editButton = button.cloneNode(false);
                editButton.innerText = 'Edit';
     ");
                WriteLiteral(@"           editButton.setAttribute('onclick', `displayEditForm(${item.id})`);

                let deleteButton = button.cloneNode(false);
                deleteButton.innerText = 'Delete';
                deleteButton.setAttribute('onclick', `deleteItem(${item.id})`);

                let tr = tBody.insertRow();

                let td1 = tr.insertCell(0);
                td1.appendChild(isCompleteCheckbox);

                let td2 = tr.insertCell(1);
                let textNode = document.createTextNode(item.name);
                td2.appendChild(textNode);

                let td3 = tr.insertCell(2);
                td3.appendChild(editButton);

                let td4 = tr.insertCell(3);
                td4.appendChild(deleteButton);
            });

            todos = data;
        }

    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreWeb.ViewModel.TodoItemsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
