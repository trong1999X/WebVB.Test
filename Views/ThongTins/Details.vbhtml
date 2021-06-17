@ModelType WebApplication1.ThongTin
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>ThongTin</h4>
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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.ID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
