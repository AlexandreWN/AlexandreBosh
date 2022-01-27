var x = document.getElementById("coisa").innerHTML

function some(id){
    document.getElementById(id).innerHTML=" ";
}

function aparece(id){
    document.getElementById(id).innerHTML=x;
}
var count = 4;
function Num(id){
    document.getElementById(id).innerHTML = count;
    count--;
    if (count < 0){
        document.getElementById("cois").disabled = true;
    }
}