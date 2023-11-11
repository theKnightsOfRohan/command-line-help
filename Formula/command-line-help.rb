# TODO: Revisit the sha256 and the tar.gz

class CommandLineHelp < Formula
  desc "A simple Help app"
  homepage "https://github.com/theKnightsOfRohan/command-line-help"
  url "https://github.com/theKnightsOfRohan/command-line-help/archive/v1.0.0.tar.gz"
  sha256 "a94a8fe5ccb19ba61c4c0873d391e987982fbbd3"
  license "MIT"

  def install
    bin.install "help"
  end
end
