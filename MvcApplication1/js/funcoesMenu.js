function MM_openBrWindow(theURL,winName,features) { window.open(theURL,winName,features); }
function fechadiv() { document.getElementById('flashcontent').style.display = "none"; }

function bgpos(id,x,y) {
	document.getElementById(id).style.background = x+" "+y+" url(images/tudo.png)";
}
function mainmenu(){
	$(" #navHidden ").css({display: "none"}); // Opera Fix
	$(" #navMenu li").hover(function(){
		$(this).find('ul').css({visibility: "visible",display: "none"}).show(0);
	},function(){
		$(this).find('ul').css({visibility: "hidden"});
	});
}

$(document).ready(function(){
	mainmenu();
});

function abrePaginaMenu(enderecoSite) {

	this.location.href = enderecoSite;
}