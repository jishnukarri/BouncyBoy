extends Node

var timer := 0.0
var started := 0
var jump_multiplier := 1.0

func _process(delta: float) -> void:
	jump_multiplier = 1 + (timer / 100) * 9
