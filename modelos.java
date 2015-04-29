// Novo

@Ajax.ActionLink("Novo", "../Cidade/Create", new AjaxOptions
            {
                InsertionMode = InsertionMode.Replace,
                UpdateTargetId = "section",
                LoadingElementId = "progress"
            })
// Editar
<div class="editar" >
@Ajax.ActionLink("Editar", "../Cidade/Edit/", new { id = item.id }
           , new AjaxOptions
               {
                   InsertionMode = InsertionMode.Replace,
                   UpdateTargetId = "section",
                   LoadingElementId = "progress"
               })
</div>
// Detalhes
@Ajax.ActionLink("Detalhes", "../Cidade/Details/", new { id = item.id }
           , new AjaxOptions
               {
                   InsertionMode = InsertionMode.Replace,
                   UpdateTargetId = "section",
                   LoadingElementId = "progress"
               })
@Ajax.ActionLink("Excluir", "../Cidade/Delete/", new { id = item.id }
           , new AjaxOptions
               {
                   InsertionMode = InsertionMode.Replace,
                   UpdateTargetId = "section",
                   LoadingElementId = "progress"
               })

               
               
// Voltar para Index
<div class="voltar">
    @Ajax.ActionLink("Voltar", "../Cidade/Index", new AjaxOptions
                                                         {
                                                             InsertionMode = InsertionMode.Replace,
                                                             UpdateTargetId = "section",
                                                             LoadingElementId = "progress"
                                                         })
</div>
// Voltar Home
<div class="voltar">
    @Html.ActionLink("Voltar", "../Basic/")
</div>

               
               
               
               
               