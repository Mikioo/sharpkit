/*Generated by SharpKit 5 v4.29.7000*/
$(OnReady);
function OnReady()
{
    $("#sortable").sortable({revert:true});
    $("#draggable").draggable({connectToSortable:"#sortable",helper:"clone",revert:"invalid"});
     $( 'ul, li' ).disableSelection();;
};
