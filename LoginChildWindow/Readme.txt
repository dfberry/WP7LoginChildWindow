Blogged at http://www.31a2ba2a-b718-11dc-8314-0800200c9a66.com/ by Dina Berry

This Windows Phone 7 application demonstrates how to grab a 
user's login and password while on a page. The Child Window 
can be called from any page so you don't have to fiddle with 
navigation silliness when the login credentials are not present. 

Caveats of this downloaded project:

1)System.windows.control is the only control that was added 
to the project. You will have to go into Windows Explorer and 
unblock it. It may be wrong version so please use your own 
version first (ie replace the reference with your own reference).

2)Child Window uses system colors.

3)Validation is shallow. You probably have a lot more checks 
to run on the user name or password.

4)I use an HTC HD7, a very large phone. The Child Window size 
and font may not work for smaller phones. 

5)Child Window placement on popup is set to the top of the 
screen. If you remove the HorizontalAlignment and 
VerticalAlignment, the window may appear in the center of 
the screen but the on-screen keyboard will overlay the
child window to the point it is difficult to use the child 
window. Cancel button was commented out for same reason. 

6)The child window cancel button (top right icon of 'x') 
was removed intentially via HasCloseButton="false." At the 
point I use it in my own application, I don't want the
user (even the smart ones) to get around entered 
their login information.

7)Child window onkey events allow customer to effectively
tab from textbox to textbox to login button.


