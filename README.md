# Selenium-Bot-Template  [![Join the chat at https://gitter.im/knikolov1t/Selenium-Bot-Template](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/knikolov1t/Selenium-Bot-Template?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge) [![PayPayl](https://img.shields.io/badge/paypal-donate-yellow.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=B8ZNZLURBKNVN "Donate once-off to this project using Paypal")
http://bit.ly/1S8AXqv
## Features
1. Styled WPF User Interface ( dark themed )
      * Also there is an image I use for background
      * Menu panel on top with working exit,settings,about,help buttons
      * LogBox - Panel for logging bot actions/status.
      * Status bar on the bottom
      * Separate window for settings
      * 'Help' window, 'About' window
2. My Selenium helper and utility functions included
      * Includes many functions for easy element selection and element waiting
      * Functions include error handling - error in message box + sound, so bot user will understand whats the problem.
      * Functions to start as Firefox, Chrome. ex: `EnterWithFirefox();`
      * Overloaded functions to start browsers with proxy. ex: `EnterWithFirefox(proxyAddress);`
      * Function for logging.
3. Multithreaded 
     * Bot actions moved another thread, different from UI.

## Installation 
  1. Open the project in VS
  2. Click 'File' > 'Export Template...' > 'Project template'
  3. When creating new project this will appear as template with the name you gave it.
  4. Open the nuget manager, nugget will ask to install your missing packages.

