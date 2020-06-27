msg = "Welcome to our site! ";
msg += "Be sure to check out our snazzy DHTML menu ";
msg += "and our daily specials. ";
pos = 0;
function ScrollMessage() {
   newtext = msg.substring(pos, msg.length) +
      "...  ..." + msg.substring(0, pos);
   newtext=newtext.substring(0,80);
   obj = document.getElementById("scroll");
   obj.firstChild.nodeValue = newtext;
   pos++;
   if (pos > msg.length) pos = 0;
   window.setTimeout("ScrollMessage()",100);
}
