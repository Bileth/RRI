using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    [SerializeField] Text storyText;
    [SerializeField] bool treasure = false;
     private enum States{
        intro, start, end, treasure_end, treasure_1, treasure_2, treasure_3, treasure_4, maze_map, 
        
        deadend_1, deadend_2, deadend_3, deadend_4, deadend_5, deadend_6, deadend_7, deadend_8,

        checkpoint_1, checkpoint_2, checkpoint_3, checkpoint_4, checkpoint_5, checkpoint_6, checkpoint_7, checkpoint_8, checkpoint_9, checkpoint_10,
        checkpoint_11, checkpoint_12, checkpoint_13, checkpoint_14, checkpoint_15, checkpoint_16, checkpoint_17, checkpoint_18, checkpoint_19, checkpoint_20,

        lost, controls
    };

    private States myState;

    // Start is called before the first frame update
    void Start()
    {
        myState = States.controls;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            Exit();
        }
        else if(myState == States.controls){
            controls();
        }
        else if(myState == States.start){
            start();
        }
        else if(myState == States.intro){
            intro();
        }
        else if(myState == States.end){
            if(treasure == true){
                treasure_end();
            }
            else
                end();
        }
        else if(myState == States.treasure_end){
            treasure_end();
        }
        else if(myState == States.treasure_1){
            treasure_1();
        }
        else if(myState == States.treasure_2){
            treasure_2();
        }
        else if(myState == States.treasure_3){
            treasure_3();
        }
        else if(myState == States.treasure_4){
            treasure_4();
        }
        else if(myState == States.checkpoint_1){
            checkpoint_1();
        }
        else if(myState == States.checkpoint_2){
            checkpoint_2();
        }
        else if(myState == States.checkpoint_3){
            checkpoint_3();
        }
        else if(myState == States.checkpoint_4){
            checkpoint_4();
        }
        else if(myState == States.checkpoint_5){
            checkpoint_5();
        }
        else if(myState == States.checkpoint_6){
            checkpoint_6();
        }
        else if(myState == States.checkpoint_7){
            checkpoint_7();
        }
        else if(myState == States.checkpoint_8){
            checkpoint_8();
        }
        else if(myState == States.checkpoint_9){
            checkpoint_9();
        }
        else if(myState == States.checkpoint_10){
            checkpoint_10();
        }
        else if(myState == States.checkpoint_11){
            checkpoint_11();
        }
        else if(myState == States.checkpoint_12){
            checkpoint_12();
        }
        else if(myState == States.checkpoint_13){
            checkpoint_13();
        }
        else if(myState == States.checkpoint_14){
            checkpoint_14();
        }
        else if(myState == States.checkpoint_15){
            checkpoint_15();
        }
        else if(myState == States.checkpoint_16){
            checkpoint_16();
        }
        else if(myState == States.checkpoint_17){
            checkpoint_17();
        }
        else if(myState == States.checkpoint_18){
            checkpoint_18();
        }
        else if(myState == States.checkpoint_19){
            checkpoint_19();
        }
        else if(myState == States.checkpoint_20){
            checkpoint_20();
        }
        else if(myState == States.maze_map){
            maze_map();
        }
        else if(myState == States.deadend_1 || myState == States.deadend_2 || myState == States.deadend_3 || myState == States.deadend_4 || myState == States.deadend_5 || myState == States.deadend_6 || myState == States.deadend_7 || myState == States.deadend_8 ){
            deadend();
        }
    }

    void lost(){
        storyText.text = "You gave up. Hoping someone will come to save you, you sit and lean on the prestine white walls wondering why this is your fate. Having your pockets full or empty seemed like a meaningless thing now as death of starvation or dehydration loomed above your head. \nBetter luck next time.";
    }
    void deadend()
    {
        storyText.text = "You hit a deadend. Go back to the last intersection?";

        if(Input.GetKeyDown(KeyCode.Y))
        {
            if(myState == States.deadend_1){
                myState = States.checkpoint_3;
            }
            else if(myState == States.deadend_2){
                myState = States.checkpoint_11;
            }
            else if(myState == States.deadend_3){
                myState = States.checkpoint_11;
            }
            else if(myState == States.deadend_4){
                myState = States.checkpoint_12;
            }
            else if(myState == States.deadend_5){
                myState = States.checkpoint_15;
            }
            else if(myState == States.deadend_6){
                myState = States.checkpoint_16;
            }
            else if(myState == States.deadend_7){
                myState = States.checkpoint_18;
            }
            else if(myState == States.deadend_8){
                myState = States.checkpoint_13;
            }
        }
        else if(Input.GetKeyDown(KeyCode.N)){
            myState = States.lost;
        }
    }

    void controls()
    {
        storyText.text = "Use the arrow keys to move around and the Y/N to answer questions. Press space to start.";
            
        if(Input.GetKeyDown(KeyCode.Space)){
            myState = States.intro;
        }
    }
     void intro()
    {
        storyText.text = "You wake up in an unfamiliar place. The sky high white walls fill you with dread as you can't remember how you got here exactly." +
            "\n \nAre you ready to face the unknown ahead?";
            
        if(Input.GetKeyDown(KeyCode.Y)){
            myState = States.start;
        }
        else if(Input.GetKeyDown(KeyCode.N)){
        myState = States.lost;
        }
    }
    void start()
    {
        storyText.text = "You are at the start! Will you go left or right?";

        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            myState = States.checkpoint_1;
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow)){
            myState = States.checkpoint_17;
        }
    }

    void end()
    {
        storyText.text = "Congratulations! You made it out of the labyrinth!" +
            "\n \nToday, you managed to escape with your head alive and your pockets empty, but there is nothing more valuable than your life. "+
            "But you can always try the labyrinth again.";
 
        if(Input.GetKeyDown(KeyCode.Space)){
            myState = States.start;
        }
    }
    void treasure_end()
    {
        storyText.text = "Congratulations! You made it out of the labyrinth!" +
            "\n \nToday, you managed to escape with your head alive and your pockets full! You loved the adventure and the thrill given.";
    }

    void treasure_1()
    {
        storyText.text = "Congratulations! You found treasure!" +
            "\nThe golden gleaming necklace promises a high payout once sold. \nYou pick up the treasure. Go back to the last intersection?";
        
        treasure = true;

        if(Input.GetKeyDown(KeyCode.Y)){
            myState = States.checkpoint_1;
        }
        else if(Input.GetKeyDown(KeyCode.N)){
            myState = States.lost;
        }
    }

    void treasure_2()
    {
        storyText.text = "Congratulations! You found treasure!" +
            "\nThe sparkling gems and diamonds lining the ring call out to your greed. \nYou pick up the treasure. Go back to the last intersection?";

        treasure = true;
        
        if(Input.GetKeyDown(KeyCode.Y)){
            myState = States.checkpoint_4;
        }
        else if(Input.GetKeyDown(KeyCode.N)){
            myState = States.lost;
        }
    }

    void treasure_3()
    {
        storyText.text = "Congratulations! You found treasure!" +
            "\nA bag full of coins and gems will no longer collect dust as you will make sure of. \nYou pick up the treasure. Go back to the last intersection?";
        
        treasure = true;

        if(Input.GetKeyDown(KeyCode.Y)){
            myState = States.checkpoint_12;
        }
        else if(Input.GetKeyDown(KeyCode.N)){
            myState = States.lost;
        }
    }

    void treasure_4()
    {
        storyText.text = "Congratulations! You found treasure!" +
            "\nThe golden dagger lined with blood red rubies makes you relax as you now have a weapon just in case. It doesn't hurt that it looks worth money as well. \nYou pick up the treasure. Go back to the last intersection?";
        
        treasure = true;

        if(Input.GetKeyDown(KeyCode.Y)){
            myState = States.checkpoint_7;
        }
        else if(Input.GetKeyDown(KeyCode.N)){
            myState = States.lost;
        }
    }

    void maze_map()
    {
        storyText.text = "The labyrinth map lied on this very floor until you picked it up! The stars mark the treasures laying around, waiting for you. Will you take the risk of getting lost or will you take the safer route and go to the exit?" +
            "\nThe red dot seems to be the spot where you picked up the map. You can go left or right.";
        
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            myState = States.checkpoint_2;
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow)){
            myState = States.checkpoint_14;
        }
    }

    void checkpoint_1()
    {
        storyText.text = "You came upon an intersection. \n \nThe writing on the wall reads: 1. Will you go up or down?";
        
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            myState = States.checkpoint_2;
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow)){
            myState = States.treasure_1;
        }
    }

    void checkpoint_2()
    {
        storyText.text = "You came upon an intersection. \n \nThe writing on the wall reads: 2. Will you go up, left or down?";
        
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            myState = States.maze_map;
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow)){
            myState = States.checkpoint_1;
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow)){
            myState = States.checkpoint_3;
        }
    }

    void checkpoint_3()
    {
        storyText.text = "You came upon an intersection. \n \nThe writing on the wall reads: 3. Will you go up, right or down?";
        
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            myState = States.checkpoint_4;
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow)){
            myState = States.deadend_1;
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow)){
            myState = States.checkpoint_2;
        }
    }

    void checkpoint_4()
    {
        storyText.text = "You came upon an intersection. \n \nThe writing on the wall reads: 4. Will you go up, right or down?";
        
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            myState = States.checkpoint_3;
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow)){
            myState = States.treasure_2;
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow)){
            myState = States.checkpoint_5;
        }
    }

    void checkpoint_5()
    {
        storyText.text = "You came upon an intersection. \n \nThe writing on the wall reads: 5. Will you go up, left or right?";
        
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            myState = States.checkpoint_6;
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow)){
            myState = States.treasure_4;
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow)){
            myState = States.checkpoint_8;
        }
    }

    void checkpoint_6()
    {
        storyText.text = "You came upon an intersection. \n \nThe writing on the wall reads: 6. Will you go right or down?";
        
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            myState = States.checkpoint_5;
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow)){
            myState = States.checkpoint_7;
        }
    }

    void checkpoint_7()
    {
        storyText.text = "You came upon an intersection. \n \nThe writing on the wall reads: 7. Will you go up, left, right or down?";
        
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            myState = States.checkpoint_8;
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow)){
            myState = States.end;
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow)){
            myState = States.checkpoint_6;
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow)){
            myState = States.treasure_4;
        }
    }
    
    void checkpoint_8()
    {
        storyText.text = "You came upon an intersection. \n \nThe writing on the wall reads: 8. Will you go up, left or right?";
        
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            myState = States.checkpoint_5;
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow)){
            myState = States.checkpoint_7;
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow)){
            myState = States.checkpoint_9;
        }
    }

    void checkpoint_9()
    {
        storyText.text = "You came upon an intersection. \n \nThe writing on the wall reads: 9. Will you go up, left or down?";
        
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            myState = States.checkpoint_8;
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow)){
            myState = States.checkpoint_10;
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow)){
            myState = States.checkpoint_13;
        }
    }

    void checkpoint_10()
    {
        storyText.text = "You came upon an intersection. \n \nThe writing on the wall reads: 10. Will you go up, right or down?";
        
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            myState = States.checkpoint_12;
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow)){
            myState = States.checkpoint_11;
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow)){
            myState = States.checkpoint_9;
        }
    }

    void checkpoint_11()
    {
        storyText.text = "You came upon an intersection. \n \nThe writing on the wall reads: 11. Will you go left, right or down?";
        
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            myState = States.deadend_3;
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow)){
            myState = States.deadend_2;
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow)){
            myState = States.checkpoint_10;
        }
    }
    void checkpoint_12()
    {
        storyText.text = "You came upon an intersection. \n \nThe writing on the wall reads: 12. Will you go up, left, or down?";
        
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            myState = States.deadend_4;
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow)){
            myState = States.checkpoint_10;
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow)){
            myState = States.treasure_3;
        }
    }

    void checkpoint_13()
    {
        storyText.text = "You came upon an intersection. \n \nThe writing on the wall reads: 13. Will you go up, left, right or down?";
        
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            myState = States.checkpoint_20;
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow)){
            myState = States.checkpoint_14;
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow)){
            myState = States.checkpoint_9;
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow)){
            myState = States.deadend_8;
        }
    }

    void checkpoint_14()
    {
        storyText.text = "You came upon an intersection. \n \nThe writing on the wall reads: 14. Will you go left, right or down?";
        
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            myState = States.checkpoint_13;
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow)){
            myState = States.maze_map;
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow)){
            myState = States.checkpoint_15;
        }
    }

    void checkpoint_15()
    {
        storyText.text = "You came upon an intersection. \n \nThe writing on the wall reads: 15. Will you go left, right or down?";
        
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            myState = States.checkpoint_14;
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow)){
            myState = States.deadend_5;
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow)){
            myState = States.checkpoint_16;
        }
    }

    void checkpoint_16()
    {
        storyText.text = "You came upon an intersection. \n \nThe writing on the wall reads: 16. Will you go left, right or down?";
        
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            myState = States.checkpoint_15;
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow)){
            myState = States.deadend_6;
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow)){
            myState = States.checkpoint_17;
        }
    }

    void checkpoint_17()
    {
        storyText.text = "You came upon an intersection. \n \nThe writing on the wall reads: 17. Will you go left, right or down?";
        
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            myState = States.checkpoint_18;
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow)){
            myState = States.checkpoint_16;
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow)){
            myState = States.start;
        }
    }

    void checkpoint_18()
    {
        storyText.text = "You came upon an intersection. \n \nThe writing on the wall reads: 18. Will you go left, right or down?";
        
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            myState = States.checkpoint_19;
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow)){
            myState = States.checkpoint_17;
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow)){
            myState = States.deadend_7;
        }
    }

    void checkpoint_19()
    {
        storyText.text = "You came upon an intersection. \n \nThe writing on the wall reads: 19. Will you go up or right?";
        
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            myState = States.checkpoint_18;
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow)){
            myState = States.checkpoint_20;
        }
    }

    void checkpoint_20()
    {
        storyText.text = "You came upon an intersection. \n \nThe writing on the wall reads: 20. Will you go left or down?";
        
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            myState = States.checkpoint_19;
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow)){
            myState = States.checkpoint_13;
        }
    }
    public void Exit(){
        Application.Quit();
    }

    public void Reset(){
        myState = States.start;
    }
}


