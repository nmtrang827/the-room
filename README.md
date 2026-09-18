# The Room

A VR room project built in Unity for CS 417: Game Development at the University of Illinois Urbana-Champaign.

The project explores VR interaction, object spawning, particle effects, spatial audio, procedural motion, materials, shaders, camera tracking, and teleportation using the Meta Quest 2.

## Features

- VR room environment with 18 distinct objects
- 22 distinct materials
- World-space UI
- Custom highlight outline shader using Shader Graph
- XR tracked camera
- Teleportation between locations
- Object spawning from an XR controller input
- Particle burst feedback when spawning objects
- Spatial audio attached to objects
- Object Space transformations
- Euler-based steady rotation
- Kinematic double-integrator motion
- Arbitrary attraction/orbital motion
- Custom six-sided skybox material
- Rainbow lighting interaction
- Object shooting with controller-directed velocity
- Quit interaction through an XR controller

## Technologies

- Unity 6000.5.6f1
- C#
- Unity Input System 1.20.0
- XR Interaction Toolkit 3.5.1
- Meta XR Core SDK 205.0.0
- OpenXR
- Meta Quest 2
- Shader Graph

## Project Structure

The main Unity project is contained in the project directory.

Scripts are used for:
- Object spawning
- Projectile motion
- Object interactions
- Lighting
- Camera and teleportation
- Procedural object motion

## Running the Project

### Requirements

- Unity 6000.5.6f1
- Meta Quest 2
- USB connection between the computer and headset
- Android/OpenXR support configured in Unity

### Build and Run

1. Open the project in Unity 6000.5.6f1.
2. Open the project scene.
3. Connect the Meta Quest 2.
4. Build the project for Android.
5. Install and launch the generated APK on the headset.

## Controls

### VR Controller

- Left controller buttons: interact with lighting and teleportation
- Right controller button: spawn an object
- Controller direction determines the initial direction of spawned object motion
- Controller quit input exits the application

Keyboard inputs are also configured for testing some interactions in the Unity Editor.


CS 417 - Game Development  
University of Illinois Urbana-Champaign  
Fall 2026
