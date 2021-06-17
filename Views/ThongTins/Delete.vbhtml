@ModelType WebApplication1.ThongTin
@Code
    ViewData("Title") = "Delete"
End Code

<div id="grad">Delete Information</div>

<h3>Are you sure you want to delete this?</h3>
<div>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Caterogy)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Caterogy)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Content)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Content)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Note)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Note)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DateTime)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DateTime)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            <div class="btn btn-back">
                @Html.ActionLink("Back to List", "Index")
            </div>        
        </div>
    End Using
</div>
