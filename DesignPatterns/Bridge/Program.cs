using Bridge.Abstractions;
using Bridge.Dependencies;
using Bridge.Implementors;
using Microsoft.Extensions.DependencyInjection;

// Bridge Pattern
// Purpose: Separates abstraction from implementation so both can vary independently
// Use case: Cross-platform apps, device drivers, GUI frameworks
// Benefits: Decouples interface from implementation, improves extensibility

var serviceProvider = BridgeConfiguration.ConfigureServices();

Console.WriteLine("=== Bridge Pattern Demo ===");
Console.WriteLine("Remote controls for different devices\n");

// Get devices from DI
var tv = serviceProvider.GetRequiredService<TV>();
var radio = serviceProvider.GetRequiredService<Radio>();

// Scenario 1: Basic remote with TV
Console.WriteLine("--- Scenario 1: Basic Remote Control with TV ---\n");
var basicRemoteForTV = new RemoteControl(tv);
basicRemoteForTV.TogglePower();
basicRemoteForTV.VolumeUp();
basicRemoteForTV.VolumeUp();
basicRemoteForTV.ChannelUp();

// Scenario 2: Advanced remote with TV
Console.WriteLine("\n--- Scenario 2: Advanced Remote Control with TV ---\n");
var advancedRemoteForTV = new AdvancedRemoteControl(tv);
advancedRemoteForTV.SetChannel(5);
advancedRemoteForTV.VolumeDown();
advancedRemoteForTV.DisplayStatus();

// Scenario 3: Basic remote with Radio
Console.WriteLine("--- Scenario 3: Basic Remote Control with Radio ---\n");
var basicRemoteForRadio = new RemoteControl(radio);
basicRemoteForRadio.TogglePower();
basicRemoteForRadio.VolumeUp();
basicRemoteForRadio.ChannelUp();
basicRemoteForRadio.ChannelUp();

// Scenario 4: Advanced remote with Radio
Console.WriteLine("\n--- Scenario 4: Advanced Remote Control with Radio ---\n");
var advancedRemoteForRadio = new AdvancedRemoteControl(radio);
advancedRemoteForRadio.SetChannel(101);
advancedRemoteForRadio.DisplayStatus();
advancedRemoteForRadio.Mute();
advancedRemoteForRadio.DisplayStatus();

// Scenario 5: Switching devices with the same remote
Console.WriteLine("--- Scenario 5: Demonstrating Independence ---\n");
Console.WriteLine("The same remote control type works with different devices:");
Console.WriteLine("• BasicRemote works with both TV and Radio");
Console.WriteLine("• AdvancedRemote works with both TV and Radio");
Console.WriteLine("• We can add new devices without changing remotes");
Console.WriteLine("• We can add new remote types without changing devices");