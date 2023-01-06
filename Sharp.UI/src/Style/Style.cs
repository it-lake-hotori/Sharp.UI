using System.Collections;

namespace Sharp.UI
{
    [SharpObject]
    public partial class Style<T> : Style
    {
        public Style() : base(MauiWrapper.GetMauiType<T>())
        {

        }

        public Style(bool applyToDerivedTypes)
            : base(MauiWrapper.GetMauiType<T>(), applyToDerivedTypes)
        {

        }
    }

    [SharpObject(typeof(Microsoft.Maui.Controls.Style))]
    public partial class Style
    {
        public Style(Type type) : base(type)
        {

        }

        public Style(Type type, bool applyToDerivedTypes) : base(type)
        {
            this.MauiObject.ApplyToDerivedTypes = applyToDerivedTypes;
        }

        Microsoft.Maui.Controls.VisualStateGroupList GetVisualStateGroupList()
        {
            Microsoft.Maui.Controls.VisualStateGroupList groupList = null;
            var groupListSetter = Setters.FirstOrDefault(e => e.Property == VisualStateManager.VisualStateGroupsProperty);
            if (groupListSetter != null)
            {
                groupList = groupListSetter.Value as Microsoft.Maui.Controls.VisualStateGroupList;
            }
            if (groupList == null)
            {
                groupList = new VisualStateGroupList();
                var setter = new Setter { Property = VisualStateManager.VisualStateGroupsProperty, Value = groupList };
                this.Setters.Add(setter);
            }
            return groupList;
        }

        Microsoft.Maui.Controls.VisualStateGroup GetCommonStatesVisualStateGroup(Microsoft.Maui.Controls.VisualStateGroupList visualStateGroupList)
        {
            var visualStateGroup = visualStateGroupList.FirstOrDefault(e => e.Name.Equals(VisualStateGroup.CommonStates));
            if (visualStateGroup == null)
            {
                visualStateGroup = new VisualStateGroup(VisualStateGroup.CommonStates);
                visualStateGroupList.Add(visualStateGroup);
            }
            return visualStateGroup;
        }

        public void Add(Trigger trigger) => this.MauiObject.Triggers.Add(trigger);
        public void Add(DataTrigger trigger) => this.MauiObject.Triggers.Add(trigger);
        public void Add(VisualStateGroupList groupList)
        {
            var setter = new Setter { Property = VisualStateManager.VisualStateGroupsProperty, Value = groupList };
            this.Setters.Add(setter);
        }

        public void Add(Microsoft.Maui.Controls.VisualStateGroup group)
        {
            GetVisualStateGroupList().Add(group);
        }

        public void Add(VisualState visualState)
        {
            var visualStateGroupList = GetVisualStateGroupList();
            GetCommonStatesVisualStateGroup(visualStateGroupList).Add(visualState);
        }
    }
}