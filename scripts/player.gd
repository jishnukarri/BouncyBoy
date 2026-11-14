extends CharacterBody3D

@onready var camera: Camera3D = $camera
@export var sensitivity := 0.004
@export var pitch_min := -PI / 4
@export var pitch_max := PI / 4

var pitch := 0.0

const SPEED = 5.0
const JUMP_VELOCITY = 4.5

func _unhandled_input(event: InputEvent) -> void:
	if event is InputEventMouseMotion and Input.is_action_pressed("drag"):
		rotation.y -= event.relative.x * sensitivity
		camera.rotation.x -= event.relative.y * sensitivity
		pitch -= event.relative.y * sensitivity
		pitch = clampf(pitch, pitch_min, pitch_max)

func _physics_process(delta: float) -> void:
	if position.y < -5: 
		position = Vector3(0, 1, 0)
	
	# Add the gravity.
	if not is_on_floor():
		velocity += get_gravity() * delta

	# Handle jump.
	if Input.is_action_just_pressed("jump") and is_on_floor():
		velocity.y = JUMP_VELOCITY

	# Get the input direction and handle the movement/deceleration.
	# As good practice, you should replace UI actions with custom gameplay actions.
	var input_dir := Input.get_vector("left", "right", "forward", "backward")
	var direction := (transform.basis * Vector3(input_dir.x, 0, input_dir.y)).normalized()
	if direction:
		velocity.x = direction.x * SPEED
		velocity.z = direction.z * SPEED
	else:
		velocity.x = move_toward(velocity.x, 0, SPEED)
		velocity.z = move_toward(velocity.z, 0, SPEED)

	move_and_slide()
