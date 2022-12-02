﻿using Sharp.UI;

namespace Sharp.UI.Example;

public partial class App : Application
{
    public App()
    {
        MainPage = new Shell
        {
            new FlyoutItem(FlyoutDisplayOptions.AsMultipleItems)
            {
                new Tab("Main")
                {
                    new ShellContent<HelloWorldPage>("Hello Page"),
                    new ShellContent<ExamplePage>("ExamplePage"),
                },

                new Tab("Lists")
                {
                    new ShellContent<TableViewPage>("TableView"),
                    new ShellContent<ListViewPage>("ListView"),
                    new ShellContent<CollectionPage>("Collection"),
                },
                new ShellContent<GridPage>("Grid"),
                new ShellContent<StyleTestPage>("Style"),
                new Tab("Triggers")
                {
                    new ShellContent<PropertyTriggerPage>("Property trigger"),
                    new ShellContent<EventTriggerPage>("Event trigger"),
                    new ShellContent<DataTriggerPage>("Data trigger"),
                    new ShellContent<MultiTriggerPage>("Multi trigger"),
                    new ShellContent<EnterExitActionsPage>("Enter/exit"),
                    new ShellContent<StateTriggerPage>("State trigger"),
                },

                new Tab("Bindings")
                {
                    new ShellContent<ViewModelPage>("View Model"),
                    new ShellContent<TestBindingsPage>("Bindings"),
                    new ShellContent<SimpleBindings>("Simple bindings")
                },

                new Tab("Other")
                {
                    new ShellContent<TestPage>("Test Page"),
                    new ShellContent<PathPage>("Path"),
                    new ShellContent<SwipeViewPage>("Swipe"),
                    new ShellContent<DefExamplePage>("Platform Def")
                }
            }
        }
        .Resources(AppResources.Default)
        .FlyoutBackgroundColor(AppColors.Gray950);
    }
}
