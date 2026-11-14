extends CSGBox3D

@onready var collision: CollisionShape3D = $area/collision

@export var friction := 1.0
@export var strength := 10.0
