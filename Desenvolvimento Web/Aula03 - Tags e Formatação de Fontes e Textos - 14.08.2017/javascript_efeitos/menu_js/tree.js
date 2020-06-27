var position=30;
function Toggle(item) {
   obj=document.getElementById(item);
   visible=(obj.style.display!="none")
   key="x" + item;
   if (visible) {
     obj.style.display="none";
     document.images[key].src="plus.gif";
   } else {
      obj.style.display="block";
      document.images[key].src="minus.gif";
   }
}
function Expand() {
   divs=document.getElementsByTagName("DIV");
   for (i=0;i<divs.length;i++) {
     if (divs[i].id.indexOf("_") >-1) continue;
     divs[i].style.display="block";
     key="x" + divs[i].id;
     document.images[key].src="minus.gif";
   }
}
function Collapse() {
   divs=document.getElementsByTagName("DIV");
   for (i=0;i<divs.length;i++) {
     if (divs[i].id.indexOf("_") >-1) continue;
     divs[i].style.display="none";
     key="x" + divs[i].id;
     document.images[key].src="plus.gif";
   }
}
function ShowHide() {
   if (!document.getElementById) return;
   thetext=document.getElementById("_text");
   thetree=document.getElementById("_tree");
   theicon=document.getElementById("icon");
   if (thetext.offsetLeft<40) {
      MoveRight();
	  theicon.innerHTML="&lt;&lt;&lt;";
   }
   else {
      MoveLeft();
      theicon.innerHTML="&gt;&gt;&gt;";
   }
}
function MoveRight() {
   thetext=document.getElementById("_text");
   thetree=document.getElementById("_tree");
   position +=10;
   thetext.style.left=position;
   if (position < thetree.offsetWidth + 10) {
      window.setTimeout("MoveRight();",3);
   }
}
function MoveLeft() {
   thetext=document.getElementById("_text");
   thetree=document.getElementById("_tree");
   position -=10;
   thetext.style.left=position;
   if (position > 30) {
      window.setTimeout("MoveLeft();",3);
   }
}

