using _07_Command.Classes;
using _07_Command.Commands;
using _07_Command.Interfaces;

namespace _07_Command;

class Program
{
    static void Main(string[] args)
    {
        SimpleRemoteControl simpleRemote = new();
        Light light = new("Garden Light");
        GarageDoor garageDoor = new();
        LightOnCommand lightOn = new(light);
        GarageDoorUpCommand garageUp = new(garageDoor);


        simpleRemote.SetCommand(lightOn);
        simpleRemote.ButtonWasPressed();
        simpleRemote.SetCommand(garageUp);
        simpleRemote.ButtonWasPressed();

        Console.WriteLine("--------------------------");

        RemoteControl remoteControl = new();
        Light livingRoomLight = new("Living Room");
        Light kitchenLight = new("Kitchen");
        CeilingFan ceilingFan = new("Living Room");
        GarageDoor garageDoor2 = new();
        Stereo stereo = new("Living Room");

        LightOnCommand livingRoomLightOn = new(livingRoomLight);
        LightOffCommand livingRoomLightOff = new(livingRoomLight);
        LightOnCommand kitchenLightOn = new(kitchenLight);
        LightOffCommand kitchenLightOff = new(kitchenLight);

        CeilingFanOnCommand ceilingFanOn = new(ceilingFan);
        CeilingFanOffCommand ceilingFanOff = new(ceilingFan);

        GarageDoorUpCommand garageDoorUp = new(garageDoor2);
        GarageDoorDownCommand garageDoorDown = new(garageDoor2);

        StereoOnWithCDCommand sterioOnWithCD = new(stereo);
        StereoOffCommand sterioOff = new(stereo);

        remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
        remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
        remoteControl.SetCommand(2, ceilingFanOn, ceilingFanOff);
        remoteControl.SetCommand(3, sterioOnWithCD, sterioOff);

        Console.WriteLine(remoteControl);

        remoteControl.OnButtonWasPushed(0);
        remoteControl.OffButtonWasPushed(0);
        remoteControl.OnButtonWasPushed(1);
        remoteControl.OffButtonWasPushed(1);
        remoteControl.OnButtonWasPushed(2);
        remoteControl.OffButtonWasPushed(2);
        remoteControl.OnButtonWasPushed(3);
        remoteControl.OffButtonWasPushed(3);

        Console.WriteLine("--------------------------");

        RemoteControlWithUndo remoteControlWithUndo = new();
        Light attickLight = new("Attick");
        LightOnCommand attickLightOn = new(attickLight);
        LightOffCommand attickLightOff = new(attickLight);
        
        remoteControlWithUndo.SetCommand(0, attickLightOn, attickLightOff);
        remoteControlWithUndo.SetCommand(1, ceilingFanOn, ceilingFanOff);

        Console.WriteLine(remoteControlWithUndo);
        remoteControlWithUndo.OnButtonWasPushed(0);
        remoteControlWithUndo.OffButtonWasPushed(0);
        Console.WriteLine(remoteControlWithUndo);
        remoteControlWithUndo.UndoButtonWasPushed();
        remoteControlWithUndo.OffButtonWasPushed(0);
        remoteControlWithUndo.OnButtonWasPushed(0);
        Console.WriteLine(remoteControlWithUndo);
        remoteControlWithUndo.UndoButtonWasPushed();

        Console.WriteLine("--------------------------");

        remoteControlWithUndo.OnButtonWasPushed(1);
        remoteControlWithUndo.OnButtonWasPushed(1);
        remoteControlWithUndo.OnButtonWasPushed(1);
        remoteControlWithUndo.OnButtonWasPushed(1);
        Console.WriteLine(remoteControlWithUndo);
        remoteControlWithUndo.UndoButtonWasPushed();
        remoteControlWithUndo.OnButtonWasPushed(1);
        Console.WriteLine(remoteControlWithUndo);
        remoteControlWithUndo.OffButtonWasPushed(1);
        remoteControlWithUndo.UndoButtonWasPushed();

        Console.WriteLine("--------------------------");
        light = new("Party Room");
        TV tv = new("Party Room");
        stereo = new("Party Room");
        Hottub hottub = new();

        LightOnCommand partyLightOn = new(light);
        LightOffCommand partyLightOff = new(light);
        TVOnCommand partyTVOn = new(tv);
        TVOffCommand partyTVOff = new(tv);
        StereoOnWithCDCommand partyStereoOn = new(stereo);
        StereoOffCommand partyStereoOff = new(stereo);
        HottubOnCommand partyHottubOn = new(hottub);
        HottubOffCommand partyHottubOff = new(hottub);

        ICommand[] partyOn = { partyLightOn, partyTVOn, partyStereoOn, partyHottubOn };
        ICommand[] partyOff = { partyLightOff, partyTVOff, partyStereoOff, partyHottubOff };

        MacroCommand partyOnMacro = new(partyOn);
        MacroCommand partyOffMacro = new(partyOff);

        remoteControl.SetCommand(0, partyOnMacro, partyOffMacro);

        Console.WriteLine(remoteControl);
        Console.WriteLine("------ Pushing Marco On ------");
        remoteControl.OnButtonWasPushed(0);
        Console.WriteLine("------ Pushing Marco Off -----");
        remoteControl.OffButtonWasPushed(0);
    }
}