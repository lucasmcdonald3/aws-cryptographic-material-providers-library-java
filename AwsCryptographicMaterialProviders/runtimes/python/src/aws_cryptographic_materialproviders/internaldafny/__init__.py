import sys

internaldafny_dir = '/'.join(__file__.split("/")[:-1])

sys.path.append(internaldafny_dir + "/extern")
sys.path.append(internaldafny_dir + "/generated")
