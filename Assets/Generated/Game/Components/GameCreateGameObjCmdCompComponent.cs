//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public CreateGameObjCmdComp createGameObjCmdComp { get { return (CreateGameObjCmdComp)GetComponent(GameComponentsLookup.CreateGameObjCmdComp); } }
    public bool hasCreateGameObjCmdComp { get { return HasComponent(GameComponentsLookup.CreateGameObjCmdComp); } }

    public void AddCreateGameObjCmdComp(string newPath) {
        var index = GameComponentsLookup.CreateGameObjCmdComp;
        var component = (CreateGameObjCmdComp)CreateComponent(index, typeof(CreateGameObjCmdComp));
        component.Path = newPath;
        AddComponent(index, component);
    }

    public void ReplaceCreateGameObjCmdComp(string newPath) {
        var index = GameComponentsLookup.CreateGameObjCmdComp;
        var component = (CreateGameObjCmdComp)CreateComponent(index, typeof(CreateGameObjCmdComp));
        component.Path = newPath;
        ReplaceComponent(index, component);
    }

    public void RemoveCreateGameObjCmdComp() {
        RemoveComponent(GameComponentsLookup.CreateGameObjCmdComp);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherCreateGameObjCmdComp;

    public static Entitas.IMatcher<GameEntity> CreateGameObjCmdComp {
        get {
            if (_matcherCreateGameObjCmdComp == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.CreateGameObjCmdComp);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCreateGameObjCmdComp = matcher;
            }

            return _matcherCreateGameObjCmdComp;
        }
    }
}