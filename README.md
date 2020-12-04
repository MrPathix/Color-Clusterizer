# Color Reducer

Color Reducer is a .NET application, made in Windows Forms using .NET 5.0 and C# 9.0. It was made for an academic project for Computer Graphics classes.

To compile the project, the user needs .NET 5.0 and Microsoft Visual Studio 16.8 or newer.

## Usage
The app is used for reducing colors of input images in three different ways: k-means algorithm, popularity algorithm & propagation of uncertainty dithering.
The first and the last are configurable by user in their own way: changing the epsilon value for k-means and filter matrix for PoUD.

Each of the pictures (including the main one) can be saved to file in its native resolution by clicking right mouse button on it and opening the context menu, then selecting the option "Save to file...".

The app already contains a default gallery of pictures in the right panel. They can be selected and operated on without any file dialog operations.
The user can also load their own images and operate on those.
