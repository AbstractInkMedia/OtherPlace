/// <summary>
///
/// Used to separate Game States and isolate logic,
/// with Game States interacting with Systems to influence the UI, Environment, Agents, etc.
/// 
/// </summary>

using System.Collections.Generic;
using UnityEngine;

public abstract class Game_State_Abstract : MonoBehaviour {

    protected Game_Systems_MapGenerator system_mapGenerator; // Used to generate and destroy the map
    protected Game_Systems_UI system_UI; // Used to handle the User Interface and interaction with it
    protected Game_Systems_AgentHandler system_agentHandler; // Used to handle agents ( Non-player agents, smart objects, etc. )
    protected Game_Systems_Player system_player; // Used to handle player input and influence associated Player Character

    // The set of one or more Game States that can be transitioned to
    protected Dictionary<string, Game_State_Abstract> transitionStates;

    // The next state, which will be transitioned to when it is no longer null
    private Game_State_Abstract nextState = null;

    /// <summary>
    /// Called by the Game State to prepare the set of any Game States it can transition to,
    /// which should include 
    /// </summary>
    protected abstract void PrepareTransitionStates ( );

    /// <summary>
    /// Called by the Game State to inform the Game_Systems_Maanger to change to the specified state
    /// </summary>
    /// <param name="nextState"></param>
    protected void SetNextState ( Game_State_Abstract nextState ) {
        this.nextState = nextState;
    }

    /// <summary>
    /// Called by Game_Systems_Manager to see if there needs to be a transition to another State
    /// </summary>
    public Game_State_Abstract GetNextState ( ) {
        if( this.nextState == null ) {
            return null;
        }
        
        // Copy the nextState, reset nextState to null, and return the copy
        Game_State_Abstract returnState = this.nextState;
        this.nextState = null;

        return returnState;
    }

    /// <summary>
    /// Used by the Game State to prepare for anything required by the Update loop
    /// </summary>
    protected abstract void PrepareState ( );

    /// <summary>
    /// Any logic for the Game State's Update loop. Note: This is named this way so as to not conflict with Update() and UpdateState()
    /// </summary>
    protected abstract void UpdateState_Private ( );

    /// <summary>
    /// The Game State must destroy or change anything that would interfere with other states,
    /// with the exception of those changes made to Game Systems
    /// </summary>
    protected abstract void EndState ( );

    /// <summary>
    /// Called by Game_Systems_Manager to enter the Game State
    /// </summary>
    public void Enter ( ) {

        // The Game State gains access to the Game Systems //

        system_mapGenerator = this.GetComponentInParent<Game_Systems_MapGenerator>( );
        system_UI = this.GetComponentInParent<Game_Systems_UI>( );
        system_agentHandler = this.GetComponentInParent<Game_Systems_AgentHandler>( );
        system_player = this.GetComponentInParent<Game_Systems_Player>( );

        PrepareState( );
    }

    /// <summary>
    /// Called by Game_Systems_Manager to run this frame's update
    /// </summary>
    public void UpdateState ( ) {
        UpdateState_Private( );
    }

    /// <summary>
    /// Called by Game_Systems_Manager to exit the Game State
    /// </summary>
    public void Exit ( ) {
        EndState( );

        // The Game State loses access to the Game Systems, so that there is no conflict between Game States
        system_mapGenerator = null;
        system_UI = null;
        system_agentHandler = null;
        system_player = null;
    }


    private void Awake ( ) {
        transitionStates = new Dictionary<string , Game_State_Abstract>( );
        PrepareTransitionStates( );
    }
}
