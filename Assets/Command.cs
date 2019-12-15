using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command
{
    public abstract void Execute(Animator anim);
}

public class MoveForward : Command
{
    public override void Execute(Animator anim)
    {
        anim.SetTrigger("isWalking");
    }
}

public class Jump : Command
{
    public override void Execute(Animator anim)
    {
        anim.SetTrigger("isJumping");
    }
}

public class Kick : Command
{
    public override void Execute(Animator anim)
    {
        anim.SetTrigger("isKicking");
    }
}

public class Punch : Command
{
    public override void Execute(Animator anim)
    {
        anim.SetTrigger("isPunching");
    }
}

public class DoNothing : Command
{
    public override void Execute(Animator anim)
    {

    }
}
