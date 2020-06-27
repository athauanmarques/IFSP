$(document).ready(function()
{
	//retrieve the menu subitems (div element child of the list element)
	//with the powerful jQuery selectors
	//and store them in a variable
	var subItems = $('ul li div');
	//retrieve the main menu items that
	//have the retrieved subitems as children.
	//Notice the handy .has() method:
	var mainItems = $('ul li').has(subItems);
	//Hide all subitems on page load
	subItems.hide();
	//Attach the .hover() function to the main
	//menu items:
	$(mainItems).hover(function()
	{
		//Apply .slideToggle() to the sub-menu
		subItems.slideToggle('fast');
	});
});