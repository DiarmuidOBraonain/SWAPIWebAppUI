# SWAPIWebAppUI

## Overview
SWAPIWebAppUI is a web application that provides a user interface for interacting with the Star Wars API (SWAPI). It allows users to browse and explore information about various entities in the Star Wars universe, including films, characters, starships, planets, species, and vehicles.

## Features
- View information about characters from all 7 Star Wars films 
- Access details for each entity, including properties and related entities.
- Responsive design for optimal viewing on different devices.

## Prerequisites
- Git tools must be installed on your device
- You must have .NET 7 (or newer) installed
- Internet connection
- Trusted SSL certificate to allow the web page to be accessed on your browser

## Installation
To run the application locally, follow these steps:

1. Run a Git Bash or powershell session (Windows) or a terminal window (MacOS)

2. Clone the repository to your desired pathway:

```console
cd <your_parent_folder>
git clone https://github.com/DiarmuidOBraonain/SWAPIWebAppUI.git
```

2. Navigate to the project directory:

```console
cd SWAPIWebAppUI
```


3. Build and run the application using the .NET CLI:

```console
dotnet run
```


4. Access the application in your web browser at [https://localhost:"localhostnumber"](https://localhost:"localhostnumber").

##User Manual

You will be presented with a header message and a button.

When you click the button, views featuring information about characters from star wars will be displayed!

If your browser blocks access to the web page due to the the "certificate invalid" error, you will need to update the file /SWAPIWebAppUI/localhost.crt with a new certificate and re-run the application

## Future Developments
- Allow searching for specific characters
- Only show a list of the characters
- Display the detailed information about a selected character from the aforementioned list ONLY when clicked.
- Display the films, starships, planets, species, and vehicles from star wars referenced in character information
- Extensive Unit testing
- Streamlined SSL certificate authentication


## Technologies Used
- ASP.NET Core
- C#
- HTML
- CSS
- JavaScript

## Contributing
Contributions to the project are welcome! If you encounter any issues or have suggestions for improvements, please feel free to [open an issue](https://github.com/DiarmuidOBraonain/SWAPIWebAppUI/issues) or submit a pull request.

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

