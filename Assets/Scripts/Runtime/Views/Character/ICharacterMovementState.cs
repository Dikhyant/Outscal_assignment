namespace Dikhyant.Outscal {
    public interface ICharacterMovementState
    {
        public ICharacterMovementStateMachine _CharacterMovementStateMachine {get; set;}
        public void Entry();
        public void Exit();
        public void Update();
    }

}
