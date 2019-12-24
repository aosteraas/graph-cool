//
//  AppView.swift
//  BagelGram
//
//  Created by Aaron Osteraas on 25/12/19.
//  Copyright © 2019 Aaron Osteraas. All rights reserved.
//

import SwiftUI

struct AppView: View {
//    static let order = Order()
    @State var selectedView = 0
    var body: some View {
        TabView(selection: $selectedView) {
            ContentView()
                .tabItem {
                    Image("list.dash")
                    Text("Menu")
            }.tag(0)
            ContentView()
                .tabItem {
                    Image(systemName: "square.and.pencil")
                    Text("Order")
            }.tag(1)
        }
    }
}

struct AppView_Previews: PreviewProvider {
    static var previews: some View {
        AppView()
    }
}
