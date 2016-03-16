#!/usr/bin/env python

import os
import sys

try:
    # Installed system wide
    from icon_font_to_png import command_line
except ImportError:
    # Locally
    sys.path.append(os.path.join(os.path.dirname(__file__), '..'))
    from icon_font_to_png import command_line


if __name__ == '__main__':
    command_line.run(sys.argv[1:])

