extends KinematicBody2D


var velocity = Vector2()
export var speed = 500

func _physics_process(delta):
	velocity = Vector2(0,0)
	
	if Input.is_action_pressed("ui_right"):
		velocity.x = speed
	if Input.is_action_pressed("ui_left"):
		velocity.x = -speed
	if Input.is_action_pressed("ui_up"):
		velocity.y = -speed
	if Input.is_action_pressed("ui_down"):
		velocity.y = speed
		
	velocity = velocity.normalized() * speed
	velocity = move_and_slide(velocity)
